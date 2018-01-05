using UnityEngine;
using System.Collections;

public class BatterySpawn : MonoBehaviour {

	public Rigidbody battery;

	public float spawnTime;

	public bool batSpawned;

	private bool spawning = false;

	public Transform spawnPoint;

	// Use this for initialization
	void Start () {
		batSpawned = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(batSpawned == false){
			if(!spawning){
				spawning = !spawning;
				StartCoroutine(SpawnBat(spawnTime, battery));
				print("Spawn Box Empty!");
			}

		}
		else if(batSpawned == true){
			print("Battery has spawned!");
			
		}
	}
	
	void OnTriggerEnter(Collider other){
		print("Collision Detected");
		if(other.gameObject.tag == "Battery"){
			print("Battery is in the trigger!");
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
