using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportation : MonoBehaviour
{
    // Start is called before the first frame update
   
    public GameObject destination; 
    public GameObject shadow;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           shadow.transform.position = destination.transform.position;
        }
    }

    
}
