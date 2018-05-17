using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour {

    [SerializeField]
    float verticalSpeed = 0.5f;
    [SerializeField]
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * verticalSpeed;
        }
		
	}
}
