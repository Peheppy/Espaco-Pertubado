using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    void Awake()
    {
        GameObject music = GameObject.FindGameObjectWithTag("music");
        DontDestroyOnLoad(music);
    }
}
