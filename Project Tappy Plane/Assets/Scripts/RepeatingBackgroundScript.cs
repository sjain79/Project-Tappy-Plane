using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackgroundScript : MonoBehaviour {
    PolygonCollider2D groundCollider;
    float groundColliderLength;

	// Use this for initialization
	void Start () {
        groundCollider = gameObject.GetComponent<PolygonCollider2D>();
        groundColliderLength = groundCollider.bounds.extents.x * 2f;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -groundColliderLength)
            RepositionBackground();
	}

    void RepositionBackground()
    {
        Vector2 offset = new Vector2(groundColliderLength * 2f, 0);
        transform.position = (Vector2)transform.position + offset;
    }
}
