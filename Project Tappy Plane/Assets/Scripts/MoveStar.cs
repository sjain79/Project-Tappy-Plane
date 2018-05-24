using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStar : MonoBehaviour {

    private void OnTriggerStay2D(Collider2D collision)
    {
        transform.position =  transform.position + new Vector3(0.2f, 0);
    }
}
