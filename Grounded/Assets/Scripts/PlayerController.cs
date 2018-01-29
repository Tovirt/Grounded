using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 4.0f;

    private Vector2 oldPos;
	private Vector2 newPos;
    private Vector2 pointTowards;
    private BoxCollider2D bc2D;
    private RaycastHit2D intObj;

	void Start () {
        bc2D = GetComponent<BoxCollider2D>();
	}

    void Update () {
        //Movement of Player
        oldPos = transform.position;
        if (Input.GetKey(KeyCode.A)) {
            newPos = oldPos + Vector2.left/5;
		}
		if(Input.GetKey(KeyCode.D)) {
            newPos = oldPos + Vector2.right/5;
		}
		if(Input.GetKey(KeyCode.W)) {
            newPos = oldPos + Vector2.up/5;
		}
		if(Input.GetKey(KeyCode.S)) {
			newPos = oldPos + Vector2.down/4;
		}
        pointTowards = newPos - oldPos;
        bc2D.enabled = false;
        if (!Physics2D.Linecast(oldPos, newPos))
        {
            transform.position = Vector3.MoveTowards(transform.position, newPos, Time.deltaTime * speed);
        }
        bc2D.enabled = true;
        // Calling Interaction
        if (Input.GetKeyDown(KeyCode.Space)){
            Interact(pointTowards);
        }
    }

    //Interacting with an object
    void Interact(Vector2 pointing){
        Debug.Log("Interaction happened");
        Vector2 position = transform.position;
        bc2D.enabled = false;
        if(intObj = Physics2D.Linecast(position, position + pointing)) {
            Debug.Log(intObj.collider.name);
            intObj.collider.SendMessage("Interaction");
        }
        bc2D.enabled = true;
    }
}