using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other) 
    {

        // If player fall into lava
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerManager>().Death();
        }

    }

}
