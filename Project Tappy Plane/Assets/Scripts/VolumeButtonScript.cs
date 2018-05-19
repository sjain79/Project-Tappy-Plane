using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeButtonScript : MonoBehaviour
{
    [SerializeField]
    Sprite volumeOn, volumeOff;

    static bool isVolumeOn;

    Image volumeImage;


    private void Awake()
    {
        volumeImage = transform.GetChild(1).GetComponent<Image>();
    }

    private void Start()
    {

        if (PlayerPrefs.GetInt("VolumeSetting", 1)==1)
        {
            volumeImage.sprite = volumeOn;
            isVolumeOn = true;
        }
        else 
        {
            volumeImage.sprite = volumeOff;
            isVolumeOn = false;
        }
    }

    
    public void OnTapButton()
    {
        if (isVolumeOn)
        {
            isVolumeOn = false;
            volumeImage.sprite = volumeOff;
            PlayerPrefs.SetInt("VolumeSetting", 0);
        }
        else
        {
            isVolumeOn = true;
            volumeImage.sprite = volumeOn;
            PlayerPrefs.SetInt("VolumeSetting", 1);
        }
    }
}
