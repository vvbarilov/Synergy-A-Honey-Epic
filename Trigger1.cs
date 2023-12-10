using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    public GameObject ScriptedPlatform;

    void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<PlatformMove>().enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<PlatformMove>().enabled = false;
    }
}
