using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCompanion : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Scripted Platform"))
        {
            this.transform.parent = collision.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Scripted Platform"))
        {
            this.transform.parent = null;
        }
    }
}
