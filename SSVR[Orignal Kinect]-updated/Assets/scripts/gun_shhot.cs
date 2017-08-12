using UnityEngine;
using System.Collections;

public class gun_shhot : MonoBehaviour {


	bool IsAttacking = false;
	public GameObject Bullet;
	public Transform SpawnPoint;
	double fireRate = 0.5;
	double nextFire = 0;
	enemy_shoot e;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (IsAttacking == true) {
			Attacking ();
		}

	}

	public void Attacking(){
		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Rigidbody Shoot = (Rigidbody)Instantiate (Bullet, SpawnPoint.position, SpawnPoint.rotation);
			Shoot.AddForce (SpawnPoint.forward * 1000);


		}


	}
		public void Is_Attack_true(){
			IsAttacking = true;
		}
	public void Is_Attack_false(){
		IsAttacking = false;
	} 
}
