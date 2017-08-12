using UnityEngine;
using System.Collections;

public class test_shooting_raycast_message : MonoBehaviour {

	public GameObject bullet;
	public GameObject bullethole1;
	public GameObject recoil;
	public GameObject flash;
	public GameObject plane;
	public GameObject head1;
	public GameObject head2;
	public GameObject head3;
	public GameObject head4;
	public GameObject body1;
	public GameObject body2;
	public GameObject body3;
	public GameObject body4;
	public GameObject lower1;
	public GameObject lower2;
	public GameObject lower3;
	public GameObject lower4;
	public GameObject target1;
	public GameObject target2;
	public GameObject target3;
	GameObject bulletHole;
	public float delayTime = 3;
	public int cc = 0;
	public int b=0;
	public int a = 0;
	public GameObject anim1;
	private float counter=0;
	// Use this for initialization
	void Start () {

	}



	// Update is called once per frame
	void FixedUpdate () {     


		if (Input.GetMouseButtonDown(0) && counter > delayTime) {

			Instantiate (bullet, transform.position, transform.rotation);
			GetComponent<AudioSource> ().Play ();
			counter = 0;
			//flash.GetComponent<Animation> ().Play ();
			//recoil.GetComponent<Animation> ().Play ();
			RaycastHit hit;
			Ray ray = new Ray (transform.position, transform.forward);
			if (Physics.Raycast (ray, out hit, 100f)) {

				bulletHole = Instantiate (bullethole1, hit.point, Quaternion.FromToRotation (Vector3.up, hit.normal)) as GameObject;
				//-----changes here------
				if (hit.collider.tag == "head1") {
					
					hit.transform.SendMessage ("HitByRay2");

				} else if (hit.collider.tag == "lower1") {
					
					//hit.transform.SendMessage ("HitByRay2");

				} else if (hit.collider.tag == "body1") {
					
					//hit.transform.SendMessage ("HitByRay2");

				}
				else if (hit.collider.tag == "door_knob") {
					//Debug.Log ("open door");
					hit.transform.SendMessage ("doorop");
				
				}
				else if (hit.collider.tag == "door_knob2") {
					//Debug.Log ("open door");
					hit.transform.SendMessage ("doorop2");

				}
				else if (hit.collider.tag == "door_knob3") {
					//Debug.Log ("open door");
					hit.transform.SendMessage ("doorop3");

				}
				else if (hit.collider.tag == "door_knob4") {
					//Debug.Log ("open door");
					hit.transform.SendMessage ("doorop4");

				}

			}

		}
		counter += Time.deltaTime;

	}
}



