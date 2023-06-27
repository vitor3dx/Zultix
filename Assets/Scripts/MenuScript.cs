using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public GameObject blackscreenObj;
	private Animator _blackscreen;
	// Use this for initialization
	void Start () {
		_blackscreen = blackscreenObj.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("return"))
		{
			_blackscreen.SetBool("started", true);
			SceneManager.LoadScene("level1");
		}
	}
}
