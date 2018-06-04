using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class LevelTwoObjectives : MonoBehaviour {
	public GameObject[] ObjectivesTickesNumbers;
	public GameObject NextLevelScreen;
	public GameObject ObjectivesScreen;
	public GameObject Car;

	public bool GoodSpeed = false;
	public bool isStopped = false;


	// Update is called once per frame
	void Update () {
		CarUserControl carUserController = Car.GetComponent<CarUserControl>();
		CarController carController = Car.GetComponent<CarController> ();

		if (GoodSpeed == true) {
			ObjectivesTickesNumbers [0].SetActive (true);
		} 
		if (stopped() == true) {
			ObjectivesTickesNumbers [1].SetActive (true);
		}

		if (GoodSpeed == true && stopped () == true) {
			ObjectivesScreen.SetActive (false);
			NextLevelScreen.SetActive (true);
			carUserController.enabled = false;
			carController.enabled = false;			}
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
