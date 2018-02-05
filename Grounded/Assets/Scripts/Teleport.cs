using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public Vector2 destination;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = destination;
    }
}
