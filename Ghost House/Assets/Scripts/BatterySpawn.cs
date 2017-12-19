using UnityEngine;
using System.Collections;

public class BatterySpawn : MonoBehaviour {

	public Rigidbody battery;

	public float spawnTime;

	public bool batSpawned;

	public Transform spawnPoint;

	// Use this for initialization
	void Start () {
		batSpawned = false;
	}
	
	// Update is called once per frame
	/*void Update () {
		
		//if(batSpawned == false){
			//StartCoroutine(SpawnBat(spawnTime, battery));
			print("Battery has spawned!");
		}
		else{
			print("Spawn box is empty!");
			//print("There is already a battery!");
		}
	}
	*/
	void OnTriggerStay(Collider other){
		print("Collision Detected");
		if(other.gameObject.tag == "Battery"){
			batSpawned = true;
		}
		else{
			batSpawned = false;
		}
	}

	//IEnumerator SpawnBat(float time, Rigidbody bat){
		//yield return new WaitForSeconds(time);
		//Instantiate(battery, spawnPoint.position, spawnPoint.rotation);
		//batSpawned = true;
	//}

}
