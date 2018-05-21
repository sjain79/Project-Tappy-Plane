using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneColorButton : MonoBehaviour
{
    [SerializeField]
    GameObject bluePlane, greenPlane, redPlane, yellowPlane;

    bool isPlaneMenuOpen = false;

    public void PlaneButtonTapped()
    {
        if (!isPlaneMenuOpen)
        {
            bluePlane.SetActive(true);
            greenPlane.SetActive(true);
            redPlane.SetActive(true);
            yellowPlane.SetActive(true);

            isPlaneMenuOpen = true;
        }
        else
        {
            bluePlane.GetComponent<Animator>().SetTrigger("Close");
            greenPlane.GetComponent<Animator>().SetTrigger("Close");
            redPlane.GetComponent<Animator>().SetTrigger("Close");
            yellowPlane.GetComponent<Animator>().SetTrigger("Close");

            //bluePlane.SetActive(false);
            //greenPlane.SetActive(false);
            //redPlane.SetActive(false);
            //yellowPlane.SetActive(false);



            bluePlane.GetComponent<RectTransform>().localPosition = new Vector2(0, 0);
            greenPlane.GetComponent<RectTransform>().localPosition = new Vector2(0, 0);
            redPlane.GetComponent<RectTransform>().localPosition = new Vector2(0, 0);
            yellowPlane.GetComponent<RectTransform>().localPosition = new Vector2(0, 0);

            isPlaneMenuOpen = false;
        }
    }

    public void PlaneColorSelect(int planeColor)
    {
        GameController.planeColor =(PlaneColor)planeColor;
        PlayerPrefs.SetInt("Plane Color", planeColor);
    }
}
