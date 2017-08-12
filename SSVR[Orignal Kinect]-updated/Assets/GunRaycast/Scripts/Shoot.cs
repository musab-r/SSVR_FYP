using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
	public GameObject bulletHole;
	public float delayTime = 0.5f;
	
	private float counter = 0;
	
	void FixedUpdate ()	
 	{
		if(Input.GetKey(KeyCode.Mouse0) && counter > delayTime)
		{
			Instantiate(bullet, transform.position, transform.rotation);
			GetComponent<AudioSource>().Play();
			counter = 0;
			
			RaycastHit hit;
			Ray ray = new Ray(transform.position, transform.forward);
			if(Physics.Raycast(ray, out hit, 100f))
			{
				Instantiate(bulletHole, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
			}
		}
		counter += Time.deltaTime;
	}
}
