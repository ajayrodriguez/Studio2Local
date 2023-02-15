using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SoundWaveMovement : MonoBehaviour
{
    private static Rigidbody rb;

    public bool slowForce = false;
    public bool quickForce = false;

    public static float power = 20;

    public static Vector3 direction;

    public static bool used = false;
    // Start is called before the first frame update
    void Start()
    {
        used = false;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (used == false)
        {
            Invoke("Destroy", 3f);
        }
        else if (used == true)
        {
            CancelInvoke();
        }
    }

    public static void Movement()
    {
        used = true;
        Debug.Log("Moving");
        rb.AddForce(direction * power);
        
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
