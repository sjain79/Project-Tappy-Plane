using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanelScript : MonoBehaviour
{
    [SerializeField]
    GameObject gameOverPanel, gameOverText;

    private void Update()
    {
        if (GameController.gameState == GameState.Gameover)
        {
            gameOverPanel.SetActive(true);
            gameOverText.SetActive(true);
        }
    }
}
