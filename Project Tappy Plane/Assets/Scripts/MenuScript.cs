using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{

    [SerializeField]
    RectTransform tapParent;

    [SerializeField]
    GameObject startGamePanel, inGamePanel, getReadyText;

    GameObject plane;



    private void Start()
    {
        plane = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        SetTapImage();
    }


    private void SetTapImage()
    {
        if (GameController.gameState == GameState.Menu)
            tapParent.transform.position = plane.transform.position;
    }

    public void FirstTap()
    {
        Debug.Log("First Tap");

        getReadyText.SetActive(true);

        for (int i=0;i<startGamePanel.transform.childCount; ++i)
        {
            if (i==getReadyText.transform.GetSiblingIndex())
            {
                continue;
            }

            startGamePanel.transform.GetChild(i).gameObject.SetActive(false);
        }
        inGamePanel.SetActive(true);
    }
}
