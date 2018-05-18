using System.Collections;
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
        if (!isPlayerDead)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector3.up * verticalSpeed;
            }
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
