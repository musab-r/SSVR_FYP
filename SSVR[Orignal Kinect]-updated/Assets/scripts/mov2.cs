using UnityEngine;
using System.Collections;

public class mov2 : MonoBehaviour {
	public float speed=1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector3 (PingPong (Time.time * speed, -4.77f, 3.75f),transform.position.y, transform.position.z);


	}

	float PingPong(float t, float minLenght, float maxLenght)
	{
		return Mathf.PingPong (t, maxLenght - minLenght) + minLenght;
	}

}
