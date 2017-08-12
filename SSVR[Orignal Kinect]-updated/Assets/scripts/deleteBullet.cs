using UnityEngine;
using System.Collections;

public class deleteBullet : MonoBehaviour {
	
	public float lifetime = 1.0f;

	// Use this for initialization
	void Start () {
	
	}


	void  Awake ()
	{
		//Destroy(gameObject, lifetime);
	}
	// Update is called once per frame
	void Update () {
		OnTriggerEnter ();
	
	}
	void OnTriggerEnter()
	{
		RaycastHit hit;
		Ray ray = new Ray (transform.position, transform.forward);
		if (Physics.Raycast (ray, out hit, 30f)) {
			Destroy(gameObject);
		}
	}
}
