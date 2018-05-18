using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUIScript : MonoBehaviour
{
    [SerializeField]
    Image scoreUnitsPlace, scoreTensPlace, scoreHundredsPlace;

    bool scoreCrossed100 = false;

    [SerializeField]
    Sprite[] numbers;

    private void Start()
    {
        scoreUnitsPlace.enabled = false;
        scoreTensPlace.enabled = false;
        scoreHundredsPlace.enabled = false;
    }

    private void Update()
    {
        ShowScore();
    }

    private void ShowScore()
    {
        if (!scoreCrossed100)
        {
            if (PlaneScript.score < 10)
            {
                scoreUnitsPlace.enabled = true;
                scoreUnitsPlace.transform.localPosition = new Vector2(0, 0);
            }
            else if (PlaneScript.score >= 10 && PlaneScript.score < 100)
            {
                scoreTensPlace.enabled = true;

                scoreUnitsPlace.transform.localPosition = new Vector2(26.5f, 0);
                scoreTensPlace.transform.position = new Vector2(-26.5f, 0);
            }
            else if (PlaneScript.score >= 100)
            {
                scoreHundredsPlace.enabled = true;

                scoreUnitsPlace.transform.localPosition = new Vector2(53, 0);
                scoreTensPlace.transform.position = new Vector2(0, 0);
                scoreHundredsPlace.transform.position = new Vector2(-53f, 0);

                scoreCrossed100 = true;
            }
        }

        scoreUnitsPlace.sprite = numbers[PlaneScript.score % 10];
        scoreTensPlace.sprite = numbers[(PlaneScript.score/10) % 10];
        scoreHundredsPlace.sprite = numbers[(PlaneScript.score/100) % 10];
    }

}
