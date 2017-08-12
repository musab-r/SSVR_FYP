using UnityEngine;
using System.Collections;

public class spawn_bullet : MonoBehaviour {

	public GameObject Bullet;
	private float counter;
	private float counter2=0;
	public GameObject obj;
	int bullet_counter=0;

	// Use this for initialization
	void Start () {
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (bullet_counter <= 10) {

			if (obj.GetComponent<AiContorlar> ().flag == 1 && counter > 0.5f) {
				Attacking ();
				counter = 0;
				counter2 = 0;
				bullet_counter += 1;

			}


		} else {
			if (counter2 < 5f) {



			} else {
				counter2 = 0;
				bullet_counter = 0;
				counter = 0;

			}
			counter2 += Time.deltaTime;
		}


		counter += Time.deltaTime;

	}

	void Attacking(){
		Instantiate(Bullet,transform.position, transform.rotation);

		//GetComponent<AudioSource> ().Play ();
		counter = 0;
	
		RaycastHit hit2;
		Ray ray2 = new Ray (transform.position, transform.forward);
		if (Physics.Raycast (ray2, out hit2, 100f)) {
			if (hit2.collider.tag == "player_test") {

				hit2.transform.SendMessage ("PlayerDamage");

			} 

		}
		


		}

	IEnumerable delay(){
		yield return new WaitForSeconds (1000);
	}
}


