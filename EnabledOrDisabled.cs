using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledOrDisabled : MonoBehaviour
{
    public GameObject PlatformTrigger;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonIsClicked()
    {
        if (PlatformTrigger.activeInHierarchy == true)
            PlatformTrigger.SetActive(false);
        else
            PlatformTrigger.SetActive(true);
    }
}
