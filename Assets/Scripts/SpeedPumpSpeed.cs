using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class SpeedPumpSpeed : MonoBehaviour {
	public int speed= 60;
	public GameObject Car;
	public GameObject SpeedLimitScreen;


	void OnTriggerEnter (Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			
			SpeedOmeter speedometer = Car.GetComponent<SpeedOmeter> ();
			GameObject MainUICanvas = GameObject.Find ("MainUICanvas");
			LevelThreeObjectives lvl3 = MainUICanvas.GetComponent<LevelThreeObjectives> ();
			lvl3.isStopped = true;
			int currentSpeed = speedometer.speed;

			if (currentSpeed < speed) {
				lvl3.aboveSpeedPumpSpeedLimit = true;	
			} else if (currentSpeed > speed) {
				SpeedLimitScreen.SetActive (true);

				CarUserControl carUserController = Car.GetComponent<CarUserControl>();
				CarController carController = Car.GetComponent<CarController> ();
				carUserController.enabled = false;
				carController.enabled = false;
			}
		}
	}
}
