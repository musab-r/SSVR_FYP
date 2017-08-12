using UnityEngine;
using System.Collections;

public class open_door : MonoBehaviour {

	public Animator an;
	// Use this for initialization

	
	// Update is called once per frame
	void Start () {
		an = this.GetComponent<Animator> ();
		an.SetBool("open", false);
	}
	void Update(){
	}
	public void doorop(){
		
		an.SetBool("open", true);
		GetComponent<AudioSource> ().Play ();
	}
}
