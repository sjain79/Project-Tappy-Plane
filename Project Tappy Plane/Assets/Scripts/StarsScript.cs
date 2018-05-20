using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsScript : MonoBehaviour {

    public GameObject player, mainCamera, Bronze, Silver, Gold;
    PlaneScript planeScript;
    ObstaclePoolScript poolScript;
    float timeSinceLastSpawned;
	void Start () {
        planeScript = player.GetComponent<PlaneScript>();
        poolScript = mainCamera.GetComponent<ObstaclePoolScript>();
        timeSinceLastSpawned = poolScript.spawnFrequency / 2f;

    }
	
	// Update is called once per frame
	void Update () {
        if (GameController.gameState == GameState.Playing)
        {
            timeSinceLastSpawned += Time.deltaTime;
            if (timeSinceLastSpawned >= poolScript.spawnFrequency * 5f)
            {
                float spawnPositionY = Random.Range(-0.4f, 0.2f);
                if (planeScript.starsCollected < 3)
                    Instantiate(Bronze, new Vector2(poolScript.spawnPositionX, spawnPositionY), Quaternion.identity);
                else if (planeScript.starsCollected < 6)
                    Instantiate(Silver, new Vector2(poolScript.spawnPositionX, spawnPositionY), Quaternion.identity);
                else if (planeScript.starsCollected < 9)
                    Instantiate(Gold, new Vector2(poolScript.spawnPositionX, spawnPositionY), Quaternion.identity);
                timeSinceLastSpawned = poolScript.spawnFrequency / 2f;
            }
        }
	}
}
