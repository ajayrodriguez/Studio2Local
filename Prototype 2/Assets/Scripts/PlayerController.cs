using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) //when left click soundwave
        {
            RaycastHit hit; //sends raycast
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //at mouse position
            if (Physics.Raycast(ray, out hit)) //detects if something is hit that has thecorresponding tag
            {
                SoundControlle.MoveForward();
                Debug.Log("working");
            }
        }
        if (Input.GetMouseButton(1)) //when left click soundwave
        {
            RaycastHit hit; //sends raycast
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //at mouse position
            if (Physics.Raycast(ray, out hit)) //detects if something is hit that has thecorresponding tag
            {
                SoundControlle.MoveBack();
                Debug.Log("working2");
            }
        }
        

    }
}
