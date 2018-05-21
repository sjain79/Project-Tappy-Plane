using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGamePanelScript : MonoBehaviour {

    [SerializeField]
    GameObject gameOverPanel;

    private void Update()
    {
        if (GameController.gameState==GameState.Gameover)
        {
            gameOverPanel.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
