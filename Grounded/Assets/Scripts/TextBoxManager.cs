using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;
	public Text theText;
	public TextAsset textfile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

	public PlayerController player;

	public bool isActive;
	public bool stopPlayerMovement;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();

		if (textfile != null) {
			textLines = (textfile.text.Split ('\n'));
		}

		if (endAtLine == 0) {
			endAtLine = textLines.Length - 1;
		}

		if (isActive) {
			EnableTextBox ();
		} else {
			DisableTextBox();
		}
	}

	void Update(){

		if (!isActive) {
			return;
		}
		theText.text = textLines [currentLine];

		if (Input.GetKeyDown (KeyCode.Space)) {
			currentLine += 1;
		}

		if (currentLine > endAtLine) {
			textBox.SetActive (false);
		}
	}
	public void EnableTextBox()
	{
		textBox.SetActive (true);
		isActive = true;

		if (stopPlayerMovement) {
			player.canMove = false;
		}
	}
	public void DisableTextBox()
	{
		textBox.SetActive (false);
		isActive = false;
		player.canMove = true;
	}

	public void ReloadScript(TextAsset theText)
	{
		if (theText != null) {
			textLines = new string[1];
			textLines = (theText.text.Split ('\n'));
		}
	}
}