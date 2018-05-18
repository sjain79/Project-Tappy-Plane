using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationButtonScript : MonoBehaviour
{
    [SerializeField]
    GameObject creditsPanel;

    public void OnTapInformationButton()
    {
        Debug.Log("Called");
        if (creditsPanel.activeInHierarchy)
        {
            creditsPanel.SetActive(false);
        }
        else
        {
            creditsPanel.SetActive(true);
        }
    }
}
