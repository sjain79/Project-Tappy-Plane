using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePoolScript : MonoBehaviour {
    [SerializeField] int obstaclePoolSize = 10;
    GameObject[] obstacles;
    public GameObject obstaclePrefab1, obstaclePrefab2, obstaclePrefab3, obstaclePrefab4;
    float timeSinceLastSpawned = 0;
    public float spawnPositionX = 10f;
    int currentObstacle = 0;
    public float spawnFrequency;
    [SerializeField] float spawnPositionY = 0f;
    bool firstPlaced = false;

	// Use this for initialization
	void Start () {
        obstacles = new GameObject[obstaclePoolSize];
        for (int i = 0; i < obstaclePoolSize; i++)
        {
            if(i%4 == 1)
            obstacles[i] = (GameObject)Instantiate(obstaclePrefab1, new Vector2(-15f, -25f), Quaternion.identity);
            else if (i % 4 == 2)
                obstacles[i] = (GameObject)Instantiate(obstaclePrefab2, new Vector2(-15f, -25f), Quaternion.identity);
            else if (i % 4 == 3)
                obstacles[i] = (GameObject)Instantiate(obstaclePrefab3, new Vector2(-15f, -25f), Quaternion.identity);
            else if (i % 4 == 0)
                obstacles[i] = (GameObject)Instantiate(obstaclePrefab4, new Vector2(-15f, -25f), Quaternion.identity);

        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameController.gameState == GameState.Playing)
        {
            spawnFrequency = 7f / PlaneScript.scrollSpeed;

            if (!firstPlaced)
            {
                spawnPositionY = Random.Range(-0.3f, 3.06f);
                obstacles[currentObstacle].transform.position = new Vector2(spawnPositionX, spawnPositionY);
                spawnPositionY = 0f;
                currentObstacle++;
                firstPlaced = true;
            }
            timeSinceLastSpawned += Time.deltaTime;

            if (timeSinceLastSpawned >= spawnFrequency)
            {
                timeSinceLastSpawned = 0;
                if (currentObstacle % 4 == 0)
                {
                    spawnPositionY = Random.Range(-0.3f, 3.06f);
                    obstacles[currentObstacle].transform.position = new Vector2(spawnPositionX, spawnPositionY);
                    spawnPositionY = 0f;
                }
                else
                    obstacles[currentObstacle].transform.position = new Vector2(spawnPositionX, spawnPositionY);
                currentObstacle++;
                if (currentObstacle >= obstaclePoolSize)
                    currentObstacle = 0;
            }
        }

        else if (GameController.gameState == GameState.Falling)
        {
            for (int i = 0; i < obstacles.Length; ++i)
            {
                obstacles[i].GetComponent<Collider2D>().enabled = false;
            }
        }

        else
        {
            firstPlaced = false;
        }
	}
}
