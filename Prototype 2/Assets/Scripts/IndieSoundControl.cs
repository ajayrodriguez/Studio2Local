using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndieSoundControl: MonoBehaviour
{
    //get the audio source attached to the game object
    private AudioSource audio;

    void Start()
    {
        //audio is the audio source attached to the game object
        audio = GetComponent<AudioSource>();
    }

    void OnMouseOver()
    {
        //when pressing E and the mouse is over that game object
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (audio.isPlaying)    //stop playing if the audio source is playing
            {
                audio.Stop();
            }
            else
            {
                audio.Play();       //start playing the audio source if it's not playing
            }
        }
    }
}
