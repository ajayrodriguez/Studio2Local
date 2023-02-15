using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundWaveMovement : MonoBehaviour
{
    private static Rigidbody rb;

    public bool slowForce = false;
    public bool quickForce = false;

    public static float power = 20;

    public static Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Movement()
    {
        
        Debug.Log("Moving");
        rb.AddForce(direction * power); 
    }
}
