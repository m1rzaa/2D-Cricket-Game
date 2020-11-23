using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changing_scene : MonoBehaviour {

	public void changescene(int scene)
	{
		SceneManager.LoadScene (scene);
	}

}
