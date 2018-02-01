using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class intCabinCode : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    void Interaction()
    {
        Debug.Log("You Destroyd the cabinet");
        Destroy(gameObject);
    }
}
