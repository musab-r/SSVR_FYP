using UnityEngine;
using System.Collections;

public class PlayerHurt : MonoBehaviour {
	public GameObject lightss;
	public GameObject lightss2;
	public GameObject lightss3;
	public Transform pl;
	int health = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayerDamage(){
		
		health -= 20;
		Debug.Log ("I AM GETTING SHOT");
		if (health < 70 && health > 40) {
			lightss.SetActive (true);
		} 
		else if (health < 40 && health > 20) 
		{
			lightss2.SetActive (true);
		} 
		else if (health == 0) 
		{
			lightss3.SetActive (true);
			Debug.Log ("I AM Dead");
			//Destroy (pl);
		} 
		else{
			
			//lightss.SetActive (false);
			//lightss2.SetActive (false);
			//lightss3.SetActive (false);
		}
	}
}
