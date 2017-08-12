using UnityEngine;
using System.Collections;

public class mov : MonoBehaviour {
	private Vector3 pos1=new Vector3(1.783f,-2.45f,0.03f);
	private Vector3 pos2=new Vector3(-4.485f,-2.45f,0.03f);
	public float speed=1.0f;
		

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin (speed * Time.time) + 1.0f) / 2.0f);
	
	}
}
