﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingOptions : MonoBehaviour
{

    public AudioMixer audioMixer;
    // Start is called before the first frame update
    public void SetVolume (float volume){
        Debug.Log(volume);
        audioMixer.SetFloat("Volume", volume);
    }
}
