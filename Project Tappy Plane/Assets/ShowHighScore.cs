using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHighScore : MonoBehaviour {

    [SerializeField]
    Image highScoreUnitsPlace, highScoreTensPlace, highScoreHundredsPlace;

    bool scoreCrossed1000 = false;

    [SerializeField]
    Sprite[] numbers;

    int highScore;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("Highscore", 0);
        highScoreUnitsPlace.enabled = false;
        highScoreTensPlace.enabled = false;
        highScoreHundredsPlace.enabled = false;
    }

    private void Update()
    {
        ShowScore();
    }

    private void ShowScore()
    {
        if (!scoreCrossed1000)
        {
            Debug.Log("Testing");
            if (highScore < 10)
            {
                highScoreUnitsPlace.enabled = true;
                highScoreUnitsPlace.transform.localPosition = new Vector2(0, 0);
            }
            else if (highScore >= 10 && PlaneScript.score < 100)
            {
                highScoreTensPlace.enabled = true;

                highScoreUnitsPlace.transform.localPosition = new Vector2(26.5f, 0);
                highScoreTensPlace.transform.position = new Vector2(-26.5f, 0);
            }
            else if (highScore >= 100)
            {
                highScoreHundredsPlace.enabled = true;

                highScoreUnitsPlace.transform.localPosition = new Vector2(53, 0);
                highScoreTensPlace.transform.position = new Vector2(0, 0);
                highScoreHundredsPlace.transform.position = new Vector2(-53f, 0);
            }
            else
            {
                scoreCrossed1000 = true;
            }
        }

        highScoreUnitsPlace.sprite = numbers[highScore % 10];
        highScoreTensPlace.sprite = numbers[(highScore / 10) % 10];
        highScoreHundredsPlace.sprite = numbers[(highScore / 100) % 10];
    }
}
