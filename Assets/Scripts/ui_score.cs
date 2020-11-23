using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ui_score : MonoBehaviour {

	Text text;
	public static int temp;
	public static int player1;
	public static int player2;

	int no;
	int zero=0;
	int over=6;
	public static int tempover=0;
	public static int tempover2=0;



	void Start () {

		player1 = 0;
		player2 = 0;
		over = 6;
		zero = 0;
		tempover = 6;
		tempover2 = 6;



		text = GetComponent<Text> ();

	}


	void Update () {


		if (no != 1) {
			temp = Random.Range (0, 7);
			text.text = temp.ToString ();
		}


	}



	public void onclick(int no_temp)
	{
		no = no_temp;


		StartCoroutine (func ());
		StartCoroutine (timedelay ());
		Debug.Log (temp);
		over--;
	

	}





	IEnumerator timedelay ()
	{
		yield return new WaitForSeconds (2);
		if (zero != 2) {
			no = 0;
		}
	}






	IEnumerator func()
	{

		if (temp == 0 || over == 0) {
			zero++;
			over = 6;
		}

		if (zero == 0) {
			player1 = player1 + temp;
			tempover--;
		}


		if (zero == 1) {
			player2 = player2 + temp;
			tempover2--;
		}

		if (zero == 1 && over == 1) {
			zero++;
		}



			

		if (zero == 2) {
			if (player1 > player2) {

				yield return new WaitForSeconds (3);
				SceneManager.LoadScene (1);
			}

			if (player2 > player1) {

				yield return new WaitForSeconds (3);
				SceneManager.LoadScene (2);
			}

			if (player2 == player1) {

				yield return new WaitForSeconds (3);
				SceneManager.LoadScene (3);
			}
		}

	}





}


