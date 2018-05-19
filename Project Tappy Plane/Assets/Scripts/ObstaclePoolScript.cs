using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePoolScript : MonoBehaviour {
    [SerializeField] int obstaclePoolSize = 5;
    GameObject[] obstacles;
    public GameObject obstaclePrefab;
    float timeSinceLastSpawned = 0;
    [SerializeField] float spawnPositionX = 10f;
    int currentObstacle = 0;
    [SerializeField] float spawnFrequency = 2f;
    [SerializeField] float spawnPositionY = 0f;

	// Use this for initialization
	void Start () {
        obstacles = new GameObject[obstaclePoolSize];
        for (int i = 0; i < obstaclePoolSize; i++)
        {
            obstacles[i] = (GameObject)Instantiate(obstaclePrefab, new Vector2(-15f, -25f), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameController.gameState == GameState.Playing)
        {
            timeSinceLastSpawned += Time.deltaTime;

            if (timeSinceLastSpawned >= spawnFrequency)
            {
                timeSinceLastSpawned = 0;
                obstacles[currentObstacle].transform.position = new Vector2(spawnPositionX, spawnPositionY);
                currentObstacle++;
                if (currentObstacle >= obstaclePoolSize)
                    currentObstacle = 0;
                Debug.Log(obstacles[currentObstacle].transform.position.x);
            }
        }
	}
}
