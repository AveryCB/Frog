using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondCoins : MonoBehaviour
{
    public static int score = 0; // static score variable

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Coin is collected
            this.gameObject.SetActive(false);

            // Increment score
            score++;

            // Log current score
            Debug.Log("Blue Score: " + score);
        }
    }
}
