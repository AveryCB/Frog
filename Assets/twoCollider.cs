using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twoCollider : MonoBehaviour
{
      void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("second Player entered the box collider");
        }
       
    } 
}
