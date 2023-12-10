using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapearing : MonoBehaviour
{
    public GameObject DissapearingPlatform;

    void OnTriggerEnter2D(Collider2D other)
    {
        DissapearingPlatform.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        DissapearingPlatform.SetActive(true);
    }
}

