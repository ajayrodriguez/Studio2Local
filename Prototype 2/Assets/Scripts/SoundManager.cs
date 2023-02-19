using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class SoundManager: MonoBehaviour
{
    //an array for all audio source
    private AudioSource[] audioSource;
    
    //an integer to check if any audio is playing
    //it's weird but somehow it worked better than bool
    private int audioCheck = 0;

    void Start()
    {
        //define the audio source array
        audioSource = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
    }

    void Update()
    {
        //when space is pressed, use the mute or unmute all function
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MuteUnmuteAll();
            audioCheck = 0;     //reset audio check to 0
        }
    }

    void MuteUnmuteAll()
    {
        //for the audio source array, if any of the audio is not mute, the audioCheck integer goes up by one
        for (int i = 0; i < audioSource.Length; i++)
        {
            if (audioSource[i].mute == false)
            {
                audioCheck++;
            }
        }

        //if the audioCheck int is not 0, then there is at least one audio source playing
        //so we mute all sound
        if (audioCheck != 0)
        {
            for (int i = 0; i < audioSource.Length; i++)
            {
                audioSource[i].mute = true;
            }
        }

        //if the audioCheck int is 0, then no audio source is playing
        //so we unmute all sound
        if (audioCheck == 0)
        {
            for (int i = 0; i < audioSource.Length; i++)
            {
                audioSource[i].mute = false;
            }
        }

    }
    



}
