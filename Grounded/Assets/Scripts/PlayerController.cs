using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb;
	private Vector3 oldPos;
	private Vector3 newPos;
    public float speed = 4.0f;

	void Start () {
        rb = GetComponent<Rigidbody2D>();      
	}

    void Update () {
        oldPos = transform.position;
        if (Input.GetKey(KeyCode.A)) {
            newPos = oldPos + Vector3.left;
		}
		if(Input.GetKey(KeyCode.D)) {
            newPos = oldPos + Vector3.right;
		}
		if(Input.GetKey(KeyCode.W)) {
            newPos = oldPos + Vector3.up;
		}
		if(Input.GetKey(KeyCode.S)) {
			newPos = oldPos + Vector3.down;
		}
        transform.position = Vector3.MoveTowards(transform.position, newPos, Time.deltaTime * speed);
	}

    /*private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        rb.velocity = movement * speed;
    }*/
}