using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { Menu, Playing, Gameover };
public enum PlaneColor { Blue, Green, Red, Yellow };

public class GameController : MonoBehaviour
{
    public static GameState gameState;
    public static PlaneColor planeColor;

    private void Awake()
    {
        planeColor = (PlaneColor)PlayerPrefs.GetInt("Plane Color", 0);
        gameState = GameState.Menu;
    }

}
