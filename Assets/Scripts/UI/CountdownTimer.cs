using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public Text countdownText;

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay();
        }
    }
    void UpdateTimerDisplay()
    {
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        countdownText.text = seconds.ToString();
    }
}
