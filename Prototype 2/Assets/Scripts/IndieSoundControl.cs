using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndieSoundControl: MonoBehaviour
{
    //get the audio source attached to the game object
    private AudioSource objectAudio;

    void Start()
    {
        //audio is the audio source attached to the game object
        objectAudio = GetComponent<AudioSource>();
    }
    
    //Diane's note: I used mute here because we want to keep the audio's tempo to keep all audio playing in sync

    void OnMouseOver()
    {
        //when pressing E and the mouse is over that game object
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objectAudio.mute)    //unmute if the audio is not playing
            {
                objectAudio.mute = false;
            }
            else
            {
                objectAudio.mute = true;      //mute the audio source if it's not playing
            }
        }
    }
}
