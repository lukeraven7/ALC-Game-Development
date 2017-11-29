using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FlashLight : MonoBehaviour {

	public bool lightOn;
	// Flashlight power capacity
	public int maxPower = 4;
	// Usable flashlight power
	public int currentPower;

	public int batDrainAmt;

	public float batDrainDelay;

	Light light;

	public Text batteryText;	
	
	// Use this for initialization
	void Start ()
	{
		// Add power to flashlight
		currentPower = maxPower;
		print("Power = " + currentPower);
		light = GetComponent<Light> ();
		// set light default to ON
		lightOn = true;
		light.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.L) && lightOn) {
		lightOn = false;
		light.enabled = false;
		}
	
		else if (Input.GetKeyUp (KeyCode.L) && !lightOn){
		lightOn = true;
		light.enabled = true;
		}
		//Update Battery UI text
		batteryText.text = currentPower.ToString();
	
		if(currentPower > 0){
			StartCoroutine(BatteryDrain(batDrainDelay,batDrainAmt));
		}
	}
		public void setLightOn(){
			lightOn = true;
		}

		public bool isLightOn(){
			return lightOn;
	}
		IEnumerator BatteryDrain(float delay, int amount){
			yield return new WaitForSeconds(delay);
			currentPower -= amount;
			if(currentPower <= 0){
				currentPower = 0;
				print("Battery is dead!");
				light.enabled = false;
		}
	}
}