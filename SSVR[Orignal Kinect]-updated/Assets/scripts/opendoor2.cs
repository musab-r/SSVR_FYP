using UnityEngine;
using System.Collections;

public class opendoor2 : MonoBehaviour {

	// Use this for initialization
	public Animator an2;
	// Use this for initialization


	// Update is called once per frame
	void Start () {
		an2 = this.GetComponent<Animator> ();
		an2.SetBool("open2", false);
	}
	void Update(){
	}
	public void doorop2(){
		
		an2.SetBool("open2", true);
		GetComponent<AudioSource> ().Play ();
	}
}
