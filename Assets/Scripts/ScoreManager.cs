using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    TimeSpan totalTime;
    public static TimeSpan clearTime;
    DateTime startDataTime;
    GameObject[] tagObjects;

    public string targetName;
    public GameObject scoreObject;
    public GameObject targetCountUI;
    public GameObject gameClear;
    public GameObject fade;
    public GameObject timerText;
    //Animator anim;

    float score = 0.0f;
    float firstObjectCount = 0.0f;
    float objectCount = 0.0f;
    float prevScore = 0.0f;
    bool firstFlame = true;
/*
    void Awake(){
        anim = scoreObject.GetComponent<Animator>();
        anim.SetBool("play", false);
    }*/
    void Start()
    {
        firstObjectCount = Check(targetName);
        startDataTime = DateTime.Now;
    }

    void Update()
    {
        objectCount = Check(targetName);
        prevScore = score;
        score = calcScore(firstObjectCount, objectCount);
        totalTime = DateTime.Now - startDataTime;
        timerText.GetComponent<Text>().text = totalTime.Minutes.ToString("00") + ":" + totalTime.Seconds.ToString("00") + "." + totalTime.Milliseconds.ToString("000");

        if(score != prevScore || firstFlame){
            firstFlame = false;
            displayScore();
            if(score >= 100){
                clearTime = totalTime;
                gameClear.SetActive(true);
                fade.SetActive(true);
                Invoke("ChangeScene", 2.0f);
            }
        }
    }
    void ChangeScene(){
        SceneManager.LoadScene("Scenes/game_end_scene");
    }
    float Check(string tagname){
        tagObjects = GameObject.FindGameObjectsWithTag(tagname);
        return tagObjects.Length;
    }
    
    float calcScore(float n1, float n2){
        float r = ((n1 - n2) / n1) * 100;
        return r;
    }

    void displayScore(){
        Text scoreText = scoreObject.GetComponent<Text>();
        string text = score.ToString("F1");
        scoreText.text =  text + "%";
        Text targetCountText = targetCountUI.GetComponent<Text>();
        targetCountText.text = objectCount + "/" + firstObjectCount;
        /*anim.SetBool("play", false);
        anim.SetBool("play", true);
        Debug.Log("aaa");*/
    }
}
