using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui_bangalore : MonoBehaviour {

	Text text;
	int temp;

	void Start () {
		text = GetComponent<Text> ();

	}


	void Update () {

		temp = ui_score.player2;

		text.text = temp.ToString ();
	}
}
