using UnityEngine;
using System.Collections;

public class enemy_shoot : MonoBehaviour {

	public Transform Player;
	public Transform enemy;
	bool IsAttacking = false;
	public GameObject Bullet;
	public Transform SpawnPoint;
	Vector3 Distance;
	float DistanceFrom;
	public float moveSpeed=2;
	double fireRate = 0.5;
	double nextFire = 0;
	GameObject aaaa;
	static Animator myAnimator;
	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		

		// Calculate the distance between the player  the enemy

		Distance = (Player.position - enemy.position );

		Distance.y = 0;
		DistanceFrom = Distance.magnitude;
		Distance/=DistanceFrom;

		// If the player is 20m away from the enemy, ATTACK!
		if (DistanceFrom < 40f) {
			enemy.LookAt (Player);
		
			if (DistanceFrom < 10f) {
				//myAnimator.SetTrigger ("isShoot");
				Attacking();

			} 
			if (DistanceFrom > 10f && DistanceFrom < 30f) {


				chase ();
			}
			else 
			{
			}
		}
	}
	void chase(){
		//enemy.GetComponent<Animator>.SetTrigger ("isRun");

		//myAnimator.SetTrigger ("isRun");
		//enemy.Translate (Vector3.forward* moveSpeed* Time.deltaTime);
		//myAnimator.SetTrigger ("isRun");
	}
	void Attacking(){
		
		//Instantiate(Bullet, hit.point, Quaternion.FromToRotation(Vector3.forward, hit.normal));
		RaycastHit hit;
		Ray ray = new Ray (transform.position, transform.forward);
		if (Physics.Raycast (ray, out hit, 100f)) {


			
			if (hit.collider.gameObject.tag == "player_hit") {
				Debug.Log ("fire");
				//Destroy (Bullet);

			}
		}

			// The enemy isn't blind so it should face the player
			//Shoot
			//if(Time.time > nextFire){
				//nextFire = Time.time + fireRate;
			//Rigidbody Shoot = (Rigidbody)Instantiate(Bullet,SpawnPoint.position,SpawnPoint.rotation);
			//Shoot.AddForce(SpawnPoint.forward*5000);

			//yield return new WaitForSeconds(3);	


		}
	}
