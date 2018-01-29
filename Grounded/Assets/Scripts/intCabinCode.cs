using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intCabinCode : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void Interaction()
    {
        Debug.Log("You Destroyd the cabinet with a hammer");
        Destroy(gameObject);
    }
}
