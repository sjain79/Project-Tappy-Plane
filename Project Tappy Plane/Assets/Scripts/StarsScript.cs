using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsScript : MonoBehaviour {

    public GameObject player, mainCamera, bronzePrefab, silverPrefab, goldPrefab;
    public Image bronzeUI, silverUI, goldUI;
    PlaneScript planeScript;
    ObstaclePoolScript poolScript;
    float timeSinceLastSpawned;
	void Start () {
        planeScript = player.GetComponent<PlaneScript>();
        poolScript = mainCamera.GetComponent<ObstaclePoolScript>();
        timeSinceLastSpawned = poolScript.spawnFrequency / 2f;
        bronzeUI.fillAmount = 0f;
        silverUI.fillAmount = 0f;
        goldUI.fillAmount = 0f;

    }
	
	// Update is called once per frame
	void Update () {
        switch (planeScript.starsCollected)
        {
            case 1:
                bronzeUI.fillAmount = 0.33f;
                break;
            case 2:
                bronzeUI.fillAmount = 0.66f;
                break;
            case 3:
                bronzeUI.fillAmount = 1f;
                break;
            case 4:
                silverUI.fillAmount = 0.33f;
                break;
            case 5:
                silverUI.fillAmount = 0.66f;
                break;
            case 6:
                silverUI.fillAmount = 1f;
                break;
            case 7:
                goldUI.fillAmount = 0.33f;
                break;
            case 8:
                goldUI.fillAmount = 0.66f;
                break;
            case 9:
                goldUI.fillAmount = 1f;
                break;
            default:
                break;


        }
    }

    public void SpawnStar()
    {
        float spawnPositionY = Random.Range(-0.6f, 0.4f);
        if (planeScript.starsCollected < 3)
        {
            Instantiate(bronzePrefab, new Vector2(poolScript.spawnPositionX + 2.5f, spawnPositionY), Quaternion.identity);
        }
        else if (planeScript.starsCollected < 6)
        {
            Instantiate(silverPrefab, new Vector2(poolScript.spawnPositionX + 2.5f, spawnPositionY), Quaternion.identity);
        }
        else if (planeScript.starsCollected < 9)
        {
            Instantiate(goldPrefab, new Vector2(poolScript.spawnPositionX + 2.5f, spawnPositionY), Quaternion.identity);
        }
    }
}
