using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerStay(Collider other)
    {
        if(!other.gameObject.CompareTag("Saw"))
        {

            if (Input.GetKey(KeyCode.Space))
            {
                other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * 1000);
            }
        }

      
    }
    void Update()
    {
        transform.localPosition = new Vector3(0,0,-1.5f);
    }
}
