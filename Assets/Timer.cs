using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    private float timeleft = 20f;

    public int timeRemaining;

    public Text TimerText;
    private float TimerValue;
    
    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;

        timeRemaining = Mathf.FloorToInt(timeleft % 60);

        TimerText.text = "Timer : " + timeRemaining.ToString();

        if(timeleft <= 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
