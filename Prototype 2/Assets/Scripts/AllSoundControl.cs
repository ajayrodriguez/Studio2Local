using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class AllSoundControl : MonoBehaviour
{
    /*
    //an array for all game objects holding an audio source
    public GameObject[] allSoundObjects;
    
    //an array of all audio sources
    private AudioSource eachAudio;

    //instead of using bool, use a integer to check if any sound is playing
    private int audioCheck = 0;

    void Start()
    {
        //get all the sound objects that are under the tag "Sound Object"
        allSoundObjects = GameObject.FindGameObjectsWithTag("SoundObject");
        Debug.Log("The number of sound objects is: " + allSoundObjects.Length);
        
        //for each sound object, find its audio source and assign it to allAudio array
        for (int i = 0; i < allSoundObjects.Length; i++)
        {
            eachAudio = allSoundObjects[i].GetComponent<AudioSource>();
            if (eachAudio.mute != true)
            {
                audioCheck++;
                
            }
        }
        Debug.Log(audioCheck);
        
    }
    */

    private AudioSource[] audioSource;
    private int audioCheck = 0;

    void Start()
    {
        //define the audio source array
        audioSource = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MuteUnmuteAll();
            audioCheck = 0;
        }
    }

    void MuteUnmuteAll()
    {
        for (int i = 0; i < audioSource.Length; i++)
        {
            if (audioSource[i].mute == false)
            {
                audioCheck++;
            }
        }

        if (audioCheck != 0)
        {
            for (int i = 0; i < audioSource.Length; i++)
            {
                audioSource[i].mute = true;
            }
        }

        if (audioCheck == 0)
        {
            for (int i = 0; i < audioSource.Length; i++)
            {
                audioSource[i].mute = false;
            }
        }

    }
    



}
