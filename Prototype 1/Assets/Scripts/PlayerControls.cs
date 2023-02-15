using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //when left click soundwave
        {
            RaycastHit hit; //sends raycast
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //at mouse position
            if (Physics.Raycast(ray, out hit) && hit.collider.tag == "SoundWave") //detects if something is hit that has thecorresponding tag
            {
                
                SoundWaveMovement.direction = Camera.main.transform.forward; //if it does, then it changes direction to camera is facing
                SoundWaveMovement.Movement(); //will start this function
            }
        }

        if (Input.GetMouseButtonDown(1)) //when right click object
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Wood")
            {
                SoundWaveMovement.power = 20;
                Vector3 spawnZone = new Vector3(hit.collider.transform.position.x,
                                                hit.collider.transform.position.y + 1.5f,
                                                hit.collider.transform.position.z); //it creates a vector 3 based on the position of the thing it hits 
                GameManager.Instance.spawn = spawnZone;
                GameManager.Instance.Spawn();
                Debug.Log("Transform is " + hit.collider.gameObject.transform);
            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Metal")
            {
                SoundWaveMovement.power = 60;
                Vector3 spawnZone = new Vector3(hit.collider.transform.position.x, 
                                                hit.collider.transform.position.y + 1.5f,
                                                hit.collider.transform.position.z);
                GameManager.Instance.spawn = spawnZone;
                GameManager.Instance.Spawn();
                Debug.Log("Transform is " + hit.collider.gameObject.transform);
            }
            
        }
       
    }
}
