using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetReadyScript : MonoBehaviour {

    [SerializeField]
    GameObject inGamePanel,startGamePanel;

    public void StartGame()
    {
        Invoke("DelayedStartGame", 0.5f);
    }

    private void DelayedStartGame()
    {
        inGamePanel = transform.parent.gameObject.transform.GetChild(1).gameObject;
        inGamePanel.SetActive(true);
        startGamePanel.SetActive(false);
        GameController.gameState = GameState.Playing;
    }
}
