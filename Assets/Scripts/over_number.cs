﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class over_number : MonoBehaviour {

	Text text;
	int over_temp2=0;

	void Start () {

		text = GetComponent<Text> ();
	}
	

	void Update () {
		over_temp2 = ui_score.tempover2;
		if (over_temp2 > -1) {
			text.text = over_temp2.ToString ();
		}
	}
}
