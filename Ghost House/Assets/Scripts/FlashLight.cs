using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour {

	public bool lightOn;

	Light light;	
	
	// Use this for initialization
	void Start () {
		light = GetComponent<Light> ();
		// set light default to ON
		lightOn = true;
		light.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.L) && ! lightOn) {
		lightOn = false;
		light.enabled = false;
	
	}
	else if (Input.GetKeyUp (KeyCode.L) && !lightOn){
		lightOn = true;
		light.enabled = true;
		}
	}
}