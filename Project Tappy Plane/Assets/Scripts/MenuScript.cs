using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

    [SerializeField]
    RectTransform tapParent;

    GameObject plane;

    private void Start()
    {
        plane = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        SetTapImage();
        //FirstTap();
    }


    private void SetTapImage()
    {
        if (GameController.gameState == GameState.Menu)
            tapParent.transform.position = plane.transform.position;
    }

    public  void FirstTap()
    {
        Debug.Log("First Tap");
        GameController.gameState = GameState.Playing;
        GameObject inGamePanel = transform.parent.gameObject.transform.GetChild(1).gameObject;
        inGamePanel.SetActive(true);
        gameObject.SetActive(false);
    }
}
