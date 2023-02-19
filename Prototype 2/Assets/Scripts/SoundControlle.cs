using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControlle : MonoBehaviour
{
    private static Rigidbody rb;
    public static SoundControlle Instance;

    public static float distanceBack = 50;

    public static float distanceForward = 5;
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
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity *= .09f;
    }

    public static void MoveBack()
    {
        if (rb.transform.position.x < distanceBack || rb.transform.position.z < distanceBack)
        {
            rb.AddForce(Camera.main.transform.forward * 10);
        }
        
    }

    public static void MoveForward()
    {
        if (rb.transform.position.x > distanceForward || rb.transform.position.z > distanceForward)
        {
            rb.AddForce(-Camera.main.transform.forward * 10);
        }
        
    }
}
