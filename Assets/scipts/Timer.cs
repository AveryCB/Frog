using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required for UI elements

public class Timer : MonoBehaviour
{
    public float timeLeft = 10.0f; // Set the countdown time here
    public GameObject floor; // Reference to the floor GameObject
    public Text timerText; // Reference to the Text component

    // Update is called once per frame
    void Update()
    {
        // Decrease timeLeft by the time since the last frame
        timeLeft -= Time.deltaTime;

        // Update timer text
        timerText.text = "Time left: " + Mathf.Round(timeLeft);

        // If the timer has reached zero
        if (timeLeft <= 0)
        {
            // Destroy the floor
            Destroy(floor);
        }
    }
}