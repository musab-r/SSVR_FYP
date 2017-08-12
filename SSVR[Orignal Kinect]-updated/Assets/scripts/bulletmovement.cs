using UnityEngine;
using System.Collections;

public class bulletmovement : MonoBehaviour {

	public float speed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		this.transform.Translate (0, 0, speed);

	}
}
