using UnityEngine;
using System.Collections;

public class AI_part1 : MonoBehaviour {
	public Transform target2;
	public Transform mytransform;


	void Update(){
		transform.LookAt (target2);
		transform.Translate (Vector3.forward * 5 * Time.deltaTime);
	}
}
