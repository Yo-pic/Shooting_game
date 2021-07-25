using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerticleScript : MonoBehaviour
{
    public GameObject particleObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.B))
        {
            playPerticle();
        }*/
    }
    void OnDestroy(){
        playPerticle();
    }
    private void playPerticle(){
        Instantiate(particleObject, this.transform.position, Quaternion.identity);
        //Destroy(this.gameObject);
    }
}
