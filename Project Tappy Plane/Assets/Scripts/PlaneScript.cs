﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour {

    [SerializeField] float verticalSpeed = 4f;
    [SerializeField] Rigidbody2D rb;
    public static bool isPlayerDead;

    public static int score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(GameController.gameState == GameState.Menu)
        {
            rb.position = new Vector2(-6f, 0);
            rb.constraints = RigidbodyConstraints2D.FreezePosition;

        }

        else if (GameController.gameState == GameState.Playing)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;

            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector3.up * verticalSpeed;
                transform.rotation = Quaternion.Euler(0, 0, 20f);
            }
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, 0.05f);

            if(isPlayerDead)
            {
                GameController.gameState = GameState.Gameover;
            }
        }

        else if(GameController.gameState == GameState.Gameover)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isPlayerDead = true;
        }
    }
}
