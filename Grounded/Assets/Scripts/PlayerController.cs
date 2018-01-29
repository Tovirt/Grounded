using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Vector3 oldPos;
	private Vector3 newPos;
    public float speed = 4.0f;
    private BoxCollider2D bc2D;

	void Start () {
        bc2D = GetComponent<BoxCollider2D>();
	}

    void Update () {
        oldPos = transform.position;
        if (Input.GetKey(KeyCode.A)) {
            newPos = oldPos + Vector3.left/5;
		}
		if(Input.GetKey(KeyCode.D)) {
            newPos = oldPos + Vector3.right/5;
		}
		if(Input.GetKey(KeyCode.W)) {
            newPos = oldPos + Vector3.up/5;
		}
		if(Input.GetKey(KeyCode.S)) {
			newPos = oldPos + Vector3.down/4;
		}
        bc2D.enabled = false;
        if (!Physics2D.Linecast(oldPos, newPos))
        {
            transform.position = Vector3.MoveTowards(transform.position, newPos, Time.deltaTime * speed);
        }
        bc2D.enabled = true;
    }
}