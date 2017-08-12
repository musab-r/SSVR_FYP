using UnityEngine;
using System.Collections;

public class bullet_message : MonoBehaviour {


	public GameObject deathh;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void HitByRay2(){
		
		Destroy(deathh);

	}
}
