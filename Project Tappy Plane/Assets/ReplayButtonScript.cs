using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButtonScript : MonoBehaviour
{
    public void ReplayButtonTapped()
    {
        PlaneScript.score = 0;
        PlaneScript.isPlayerDead = false;
        GameController.gameState = GameState.Menu;
        SceneManager.LoadScene(0);
    }
}
