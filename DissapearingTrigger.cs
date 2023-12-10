using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearingTrigger : MonoBehaviour
{
    public GameObject DisapTrigger;
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
        if (DisapTrigger.activeInHierarchy == true)
            DisapTrigger.SetActive(false);
        else
            DisapTrigger.SetActive(true);
    }
}
