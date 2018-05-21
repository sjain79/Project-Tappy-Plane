using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { Menu, Playing, Falling, Gameover };
public enum PlaneColor { Blue, Green, Red, Yellow };

public class GameController : MonoBehaviour
{
    public static GameState gameState;
    public static PlaneColor planeColor;



    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().enabled = false;
        planeColor = (PlaneColor)PlayerPrefs.GetInt("Plane Color", 0);
        gameState = GameState.Menu;
    }

    private void Start()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().enabled = true;

    }

}
