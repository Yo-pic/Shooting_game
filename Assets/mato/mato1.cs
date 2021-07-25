using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mato1 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            Destroy(gameObject, 0.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
