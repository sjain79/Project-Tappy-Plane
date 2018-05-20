using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObjectScript : MonoBehaviour {
    [SerializeField] Rigidbody2D rb;

	
	// Update is called once per frame
	void Update () {
		if(PlaneScript.isPlayerDead)
        {
            rb.velocity = Vector3.zero;
        }
        else
        {
            rb.velocity = Vector3.left * PlaneScript.scrollSpeed;
        }
	}
}
