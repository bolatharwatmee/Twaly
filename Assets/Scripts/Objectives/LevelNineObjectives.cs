	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class LevelNineObjectives : MonoBehaviour {

	public GameObject[] ObjectivesTickesNumbers;
	public GameObject NextLevelScreen;
	public GameObject ObjectivesScreen;
	public GameObject Car;

	public bool isCrossTrafficLights_Right;
	public bool isStopped;
	public static bool isStoppedTraffic ;

	void Update () {
		CarUserControl carUserController = Car.GetComponent<CarUserControl>();
		CarController carController = Car.GetComponent<CarController> ();

		if (isStoppedTraffic == true ) {
			ObjectivesTickesNumbers [0].SetActive (true);
		}
		if (isCrossTrafficLights_Right == true) {
			ObjectivesTickesNumbers [1].SetActive (true);
		}
		if (stopped () == true) {
			ObjectivesTickesNumbers [2].SetActive (true);
		}
		if (isStoppedTraffic == true && isCrossTrafficLights_Right == true && stopped () == true) {
			ObjectivesScreen.SetActive (false);
			NextLevelScreen.SetActive (true);
			carUserController.enabled = false;
			carController.enabled = false;
		}
	
	}

	bool stopped(){
		SpeedOmeter speedometer = Car.GetComponent<SpeedOmeter> ();
		if(speedometer.speed == 0 && isStopped == true){
			return true;
		}
		else{
			return false;
		}
	}
}
