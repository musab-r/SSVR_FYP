using UnityEngine;
using System.Collections;

public class opendoor3 : MonoBehaviour {

	public Animator an3;
	// Use this for initialization


	// Update is called once per frame
	void Start () {
		an3 = this.GetComponent<Animator> ();
		an3.SetBool("open3", false);
	}
	void Update(){
	}
	public void doorop3(){
		GetComponent<AudioSource> ().Play ();
		an3.SetBool("open3", true);

	}
}
