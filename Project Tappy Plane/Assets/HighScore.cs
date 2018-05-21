using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    [SerializeField]
    GameObject newHighScoreText, showHighScoreText, highScoreNumber;

    private void Start()
    {
        if (PlayerPrefs.GetInt("Highscore",0)<PlaneScript.score)
        {
            newHighScoreText.SetActive(true);
            highScoreNumber.SetActive(false);
            PlayerPrefs.SetInt("Highscore", PlaneScript.score);
        }
        else
        {
            highScoreNumber.SetActive(true);
            showHighScoreText.SetActive(true);
        }
    }
}
