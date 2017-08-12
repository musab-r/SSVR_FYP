using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class jhgfd : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SelectMission(){
		SceneManager.LoadScene ("Select Mission");
	}
}
