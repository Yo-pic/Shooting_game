using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameEndScript : MonoBehaviour
{
    public GameObject textObject;
    TimeSpan clearTime;
    // Start is called before the first frame update
    void Start()
    {
        clearTime = ScoreManager.clearTime;
        textObject.GetComponent<Text>().text = clearTime.Minutes.ToString("00") + ":" + clearTime.Seconds.ToString("00") + "." + clearTime.Milliseconds.ToString("000");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
