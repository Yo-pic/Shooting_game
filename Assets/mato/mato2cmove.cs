using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mato2cmove : MonoBehaviour
{
    int counter = 0;
    float move = 0.05f;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
       Vector3 p = new Vector3(move, move, move);
       transform.Translate(p);
       counter++;

       if (counter == 100)
       {
           counter = 0;
           move *= -1;
       }
    }
    
}
