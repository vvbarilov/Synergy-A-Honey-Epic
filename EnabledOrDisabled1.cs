using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledOrDisabled1 : MonoBehaviour
{
    public GameObject PlatformTrigger1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void whenButtonIsClicked()
    {
        if (PlatformTrigger1.activeInHierarchy == true)
            PlatformTrigger1.SetActive(false);
        else
            PlatformTrigger1.SetActive(true);
    }
}
