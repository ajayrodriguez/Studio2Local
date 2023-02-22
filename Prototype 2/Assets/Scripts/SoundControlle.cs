using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundControlle : MonoBehaviour
{
    private Rigidbody rb;
    public Material muted;
    public Material notMuted;
   
    //get the audio source attached to the game object
    private AudioSource objectAudio;
    private Renderer color;
    public float distanceBack = 15;

    public float distanceForward = 2;
    // Start is called before the first frame update
   
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>(); //gets rigidbody that exists on this specific instance (The gameobject connected to the script)

        color = gameObject.GetComponent<Renderer>();
        
        //audio is the audio source attached to the game object
        objectAudio = gameObject.GetComponent<AudioSource>();

    }
    //Diane's note: I used mute here because we want to keep the audio's tempo to keep all audio playing in sync

    // Update is called once per frame
    void Update()
    {
        rb.velocity *= .09f;

        if (objectAudio.mute == false)
        {
            color.material = notMuted;
        }
        else
        {
            color.material = muted;
        }
    }

    public void MoveBack()
    {
        if (Mathf.Abs(rb.transform.position.x) < distanceBack || Mathf.Abs(rb.transform.position.z) < distanceBack)
        {
            rb.AddForce(Camera.main.transform.forward * 10); //not working for some reason
        }
        //Mathf.Abs turns the number into an absolute value 
        //this means the distance away from 0. Because the negative doenst matter here, turning it into absolute value
        // allows the game objects in the negative position to move. The code says that if the position is less than distance
        //it cannot move, but some are in a negative position so they cant move. However, because I turned it to absolute, it is thinking to relative position
        //so the negative 2 position is an absolute value of 2 to the 0.
    }

    public void MoveForward()
    {
        if (Mathf.Abs(rb.transform.position.x) > distanceForward || Mathf.Abs(rb.transform.position.z) > distanceForward)
        {
            rb.AddForce(-Camera.main.transform.forward * 10);
        }
        
    }
    
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
