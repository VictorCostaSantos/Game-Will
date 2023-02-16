using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("You hitted");
    }
}
