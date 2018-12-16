using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    // Use this for initialization

    public Text timeText;
    //public float startTime;

    void Awake()
    {

        float startTime = Time.time;

    }
    void Update()
    {

        float currentTime = 60 - Time.time;

        string seconds = currentTime.ToString("f1");

        timeText.text = seconds;

    }

}
