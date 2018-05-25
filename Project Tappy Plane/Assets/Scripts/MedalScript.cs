using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedalScript : MonoBehaviour
{
    public int minScoreBronze, minScoreSilver, minScoreGold;

    public Sprite bronzeMedal, silverMedal, goldMedal;

    Image image;

    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        PlaneScript planeScript = player.GetComponent<PlaneScript>();

        image = GetComponent<Image>();

        if (planeScript.starsCollected >= minScoreBronze && planeScript.starsCollected < minScoreBronze)
        {
            image.sprite = bronzeMedal;
        }
        else if (planeScript.starsCollected >= minScoreSilver && planeScript.starsCollected < minScoreGold)
        {
            image.sprite = silverMedal;
        }
        else if (planeScript.starsCollected >= minScoreGold)
        {
            image.sprite = goldMedal;
        }
    }
}
