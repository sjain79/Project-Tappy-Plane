using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { Menu, Playing, Gameover };

public class GameController : MonoBehaviour
{ 
    public static GameState gameState;

    private void Awake()
    {
        gameState = GameState.Menu;
    }

}
