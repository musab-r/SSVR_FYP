using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public class AiContorlar : MonoBehaviour
{
	Animator Ani;
	bool Inrange, Punching;
	public Transform Player;
	public float Range;
	public bool death;
	public float dist = 0f;
	public int flag = 0;
	//public GameObject Bullet;
	//public Transform SpawnPoint;


	// Use this for initialization
	void Start ()
	{
		Ani = gameObject.GetComponent<Animator> ();
		Inrange = false;
		Punching = false;
		death = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		dist = Vector3.Distance (Player.position, transform.position);
		if (dist <= Range) {
			gameObject.GetComponent<AICharacterControl> ().SetTarget (Player);
			//this.GetComponent<AICharacterControl> ().SetTarget (null);
			Inrange = true;
		}
		if (Inrange) {
			if (dist <=10.0002) {
				//this.GetComponent<AICharacterControl> ().SetTarget (null);
				//Inrange = false;


				//gameObject.GetComponent<AICharacterControl> ().SetTarget (null);
				var lookPos = Player.position - transform.position;
				var rotation = Quaternion.LookRotation (lookPos);
				transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * 60f);

				var lookPos2 = transform.position - Player.position;
				var rotation2 = Quaternion.LookRotation (lookPos2);
				//Player.rotation = Quaternion.Slerp (transform.rotation, rotation2, Time.deltaTime * 60f);
				flag =1;
				if (!Punching) {
					//Punching = true;
					//InvokeRepeating ("Punch", 0, 0.12f);
				}
			} else {
				gameObject.GetComponent<AICharacterControl> ().SetTarget (Player);
				CancelInvoke ();
				Punching = false;
			}
		}
		 else {
			CancelInvoke ();
			gameObject.GetComponent<AICharacterControl> ().SetTarget (null);
			Punching = false;
		}

	}


	/*public void Hitt ()
	{
		if (gameObject.GetComponent<EnemyHealth> ().Health > 5) {
			CancelInvoke ();
			Inrange = false;
			Ani.SetTrigger ("Hitt");
			InvokeRepeating ("Punch", 1, 0.12f);
		}
	}*/

	/*void Punch ()
	{
		if (!Ani.GetCurrentAnimatorStateInfo (0).IsName ("Punch")) {
			print ("inn");
			//Inrange = true;
			Ani.SetTrigger ("Punch");
			Debug.Log ("here in punch");
			//Player.gameObject.GetComponent<PlayerControler> ().GetDamage (2);
			//Player.gameObject.GetComponent<Animator> ().SetTrigger ("Hitt");
		}
	}*/


}
