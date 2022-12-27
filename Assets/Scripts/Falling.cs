using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public Rigidbody rb;

    public float gravityScale;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = Vector3.Lerp(rb.velocity, Vector3.zero, 0.05f);
        }
        else
        {

            rb.velocity = Vector3.down*gravityScale* Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Saw")
        {
      //      Time.timeScale = 0;
        }
    }
}
