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
        StartCoroutine(StartLoadAsync());
    }


    IEnumerator StartLoadAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(0);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
