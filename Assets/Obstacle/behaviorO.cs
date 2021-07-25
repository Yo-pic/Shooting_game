using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behaviorO : MonoBehaviour
{
    float impacts = 50;
    Rigidbody rb = null;
    // Start is called before the first frame update
    void Start()
    {
        var obstacle = GameObject.FindGameObjectWithTag("obstacle");
        var rb = obstacle.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.down * impacts, ForceMode.Impulse);
        rb.AddForce(Vector3.left * impacts, ForceMode.Impulse);
        rb.AddForce(Vector3.forward * impacts, ForceMode.Impulse);
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        if (rb.velocity.magnitude > 200)
        {
            rb.drag = 100;
        }
        else
        {
            rb.drag = 0;
        }

        
    }

    private void Update()
    {
      
    }


}
