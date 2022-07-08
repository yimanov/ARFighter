using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class fixPanel : MonoBehaviour {


	public GameObject errorPanel;
	public GameObject refreshButton;
	public GameObject cameraButton;
	private string s = "";

	// Use this for initialization
	void Start () {
		s = SceneManager.GetActiveScene().name;
	}
	
	// Update is called once per frame
	void Update () {

		if(DefaultTrackableEventHandler.trueFalse==true){
			errorPanel.SetActive(false);
			cameraButton.SetActive(false);
		}



	}

	public void refresh(){

		SceneManager.LoadScene(s);

	}


}
