using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    { 
        GetComponentInParent<PlatformMove>().enabled = true; 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponentInParent<PlatformMove>().enabled = false;
    }
}
