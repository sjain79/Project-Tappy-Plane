using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCheckCollisionScript : MonoBehaviour {

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            gameObject.transform.position = new Vector2(collision.gameObject.transform.position.x + 0.5f, gameObject.transform.position.y);
        }
    }
}
