using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject laser;
    public Transform spawnPoint;
    public float speed = 1000;

    float interval = 0.1f;
    float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0) || Input.GetMouseButton(0)){
            if(time >= interval){
                shoot();
                time = 0.0f;
            }
            
        }
        
        
    }
    void shoot()
    {
        GameObject newBullett = Instantiate(bullet) as GameObject;
        Vector3 force;
        force = this.gameObject.transform.forward * speed;
        newBullett.GetComponent<Rigidbody>().AddForce(force);
        newBullett.transform.position = spawnPoint.position;
    }
}
