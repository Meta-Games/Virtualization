using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WorldHandler : MonoBehaviour {

	public Text text;
	public bool check;
	// Use this for initialization
	void Start () {
		check = false;
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void ReloadLinkWorld ()
	{
		if (check) {
			SceneManager.LoadScene ("LinkTestZone");
		} else {
			text.text = "Are you sure? You didnt just accidentally hit the button";
		}
	}
}
