using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

//NOT DONE (Changes volume)

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
