using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePoolScript : MonoBehaviour {
    [SerializeField] int obstaclePoolSize = 5;
    GameObject[] obstacles;
    [SerializeField] GameObject obstaclePrefab;
	// Use this for initialization
	void Start () {
        obstacles = new GameObject[obstaclePoolSize];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
