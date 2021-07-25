using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportP : MonoBehaviour
{
    
    Transform tf;

    // Start is called before the first frame update
    void Start()
    {
       
  
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            tf = this.transform;
            Vector3 playerTf = tf.position;
            playerTf.x = Random.Range(-30.0f, 30.0f);
            playerTf.y = Random.Range(10.0f, 60.0f);
            playerTf.z = Random.Range(-30.0f, 30.0f);
            tf.position = playerTf;
        }
    }
}