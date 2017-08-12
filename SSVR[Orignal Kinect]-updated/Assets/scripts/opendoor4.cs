using UnityEngine;
using System.Collections;

public class opendoor4 : MonoBehaviour {

	public Animator an4;
	// Use this for initialization


	// Update is called once per frame
	void Start () {
		an4 = this.GetComponent<Animator> ();
		an4.SetBool("open4", false);
	}
	void Update(){
	}
	public void doorop4(){
		
		an4.SetBool("open4", true);

	}
}
