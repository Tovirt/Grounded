using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Vector2 pos;
	float speed = 3.0f;

	void Start () {
		pos = transform.position;
	}

	void Update () {
		if(Input.GetKey(KeyCode.A) && transform.position == pos) {
			pos += Vector2.left;
		}
		if(Input.GetKey(KeyCode.D) && transform.position == pos) {
			pos += Vector2.right;
		}
		if(Input.GetKey(KeyCode.W) && transform.position == pos) {
			pos += Vector2.up;
		}
		if(Input.GetKey(KeyCode.S) && transform.position == pos) {
			pos += Vector2.down;
		}
		transform.position = Vector2.MoveTowards(transform.position, pos, Time.deltaTime * speed);
	}
}