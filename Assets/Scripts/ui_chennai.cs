using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui_chennai : MonoBehaviour {

	Text text;
	int tempq;

	void Start () {
		text = GetComponent<Text> ();
		
	}
	

	void Update () {

		tempq = ui_score.player1;
		text.text = tempq.ToString ();
	}
}
