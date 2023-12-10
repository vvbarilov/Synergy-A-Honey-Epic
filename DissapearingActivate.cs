using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearingActivate : MonoBehaviour
{
    public GameObject DissapearingPlatform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void WhenButtonIsclicked()
    {
        if (DissapearingPlatform.activeInHierarchy == true)
            DissapearingPlatform.SetActive(false);
        else
            DissapearingPlatform.SetActive(true);
    }
}

