using UnityEngine;
using System.Collections;

public class lightcontrol : MonoBehaviour {

    public Light mylight;
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("space"))
        {
            mylight.enabled = true;
        }
        else
        {
            mylight.enabled = false;
        }
	}
}
