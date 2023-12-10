using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerProgramming : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    { 
        GetComponentInChildren<Canvas>().enabled = true; 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponentInChildren<Canvas>().enabled = false;
    }
}
