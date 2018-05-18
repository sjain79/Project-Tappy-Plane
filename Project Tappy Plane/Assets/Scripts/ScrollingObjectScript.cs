using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObjectScript : MonoBehaviour {
    [SerializeField] Rigidbody2D rb;
    public float scrollSpeed = 1.5f;


	// Use this for initialization
	void Start () {
        rb.velocity = Vector3.left * scrollSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		if(PlaneScript.isPlayerDead)
        {
            rb.velocity = Vector3.zero;
        }
	}
}
