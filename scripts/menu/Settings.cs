using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settings;
    public AudioMixer audioMixer;

    public void Back()
    {
        mainMenu.SetActive(true);
        settings.SetActive(false);
    }
    public void SetVolume(float volume)
        {
        audioMixer.SetFloat("volume", volume);
    }

}
