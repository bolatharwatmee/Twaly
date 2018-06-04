using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class LevelSixObjectives : MonoBehaviour {
	public GameObject[] ObjectivesTickesNumbers;
	public GameObject NextLevelScreen;
	public GameObject ObjectivesScreen;
	public GameObject Car;

	
	void Update () {
		CarUserControl carUserController = Car.GetComponent<CarUserControl>();
		CarController carController = Car.GetComponent<CarController> ();

		if (SpeedPumpLimiter.isGoodSpeed == true) {
			ObjectivesTickesNumbers [0].SetActive (true);
		}
		if (ParkingTrigger1.touch == true  && ParkingTrigger1.touch == true && ParkingTrigger3.touch == true && ParkingTrigger4.touch == true  ) {
			ObjectivesTickesNumbers [1].SetActive (true);
		}
		if (stopped () == true) {
			ObjectivesTickesNumbers [2].SetActive (true);
		}
		if (SpeedPumpLimiter.isGoodSpeed == true && ParkingTrigger1.touch == true && ParkingTrigger4.touch == true && stopped () == true ) {
			ObjectivesScreen.SetActive (false);
			NextLevelScreen.SetActive (true);
			carUserController.enabled = false;
			carController.enabled = false;		}
		
	}

	bool stopped(){
		SpeedOmeter speedometer = Car.GetComponent<SpeedOmeter> ();
		if(speedometer.speed == 0 && ParkingTrigger1.isStopped == true){
			return true;
		}
		else{
			return false;
		}
	}

}
