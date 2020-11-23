using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changin : MonoBehaviour {

	public void changescene(int scene)
	{
		SceneManager.LoadScene (scene);
	}

}
