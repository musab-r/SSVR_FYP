using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class radius_detection : MonoBehaviour {

	public Transform target;
	public GameObject enemy;

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	void Update () {
			float distance = Vector3.Distance (target.position, transform.position);
		if(distance < 30 )
			transform.LookAt (target);
		}
	}
