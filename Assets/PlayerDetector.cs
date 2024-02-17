using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            
            Debug.Log("Player entered the trigger zone!");
        }
    }

  
}
