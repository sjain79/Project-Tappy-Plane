using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedalScript : MonoBehaviour
{
    [SerializeField]
    int minScoreBronze, minScoreSilver, minScoreGold;

    [SerializeField]
    Sprite bronzeMedal, silverMedal, goldMedal;

    Image image;

    private void Start()
    {
        image = GetComponent<Image>();

        if (PlaneScript.score>minScoreBronze)
        {
            image.sprite = bronzeMedal;   
        }
        else if (PlaneScript.score > minScoreSilver)
        {
            image.sprite = silverMedal;
        }
        else if (PlaneScript.score > minScoreGold)
        {
            image.sprite = goldMedal;
        }
    }
}
