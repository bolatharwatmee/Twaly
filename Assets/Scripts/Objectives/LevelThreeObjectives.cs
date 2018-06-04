using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class LevelThreeObjectives : MonoBehaviour {

	public GameObject[] ObjectivesTickesNumbers;
	public GameObject NextLevelScreen;
	public GameObject ObjectivesScreen;
	public GameObject Car;

	public bool aboveSpeedPumpSpeedLimit = false;
	public bool isStopped= false;


	void Update(){
		CarUserControl carUserController = Car.GetComponent<CarUserControl>();
		CarController carController = Car.GetComponent<CarController> ();
		SpeedLimit speedLimit = GetComponent<SpeedLimit> ();

		if (aboveSpeedPumpSpeedLimit == true) {
			ObjectivesTickesNumbers [0].SetActive (true);
		}
		if (stopped () == true) {
			ObjectivesTickesNumbers [1].SetActive (true);
		}

		if (aboveSpeedPumpSpeedLimit == true && stopped () == true) {
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
