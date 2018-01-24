using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Vector3 pos;
	float speed = 3.0f;

	void Start () {
		pos = transform.position;
	}

	void Update () {
		if(Input.GetKey(KeyCode.A) && transform.position == pos) {
			pos += Vector3.left;
		}
		if(Input.GetKey(KeyCode.D) && transform.position == pos) {
			pos += Vector3.right;
		}
		if(Input.GetKey(KeyCode.W) && transform.position == pos) {
			pos += Vector3.up;
		}
		if(Input.GetKey(KeyCode.S) && transform.position == pos) {
			pos += Vector3.down;
		}
		transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
	}
}