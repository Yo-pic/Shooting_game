using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class instruction : MonoBehaviour
{
   private float timer = 0.0f;
   
    void Update()
    {
        timer += Time.deltaTime; 

        if(timer >= 3.0f)
        {
            SceneManager.LoadScene("Scenes/main");
        }
    }
       
   
    
}
