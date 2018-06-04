using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class SpeedLimit : MonoBehaviour {
	public GameObject Car;
	public int speedLimit = 60 ;
	public int speedLimitPause = 70 ;
	private int speedInt;
	public GameObject WarringMessgeText;
	public GameObject WarringScreen;
	public bool aboveSpeed;

	void Update (){
		SpeedOmeter speedometer = Car.GetComponent<SpeedOmeter> ();

		if (speedometer.speed > speedLimit && speedometer.speed < speedLimitPause) {
			WarringMessgeText.SetActive (true);
			aboveSpeed =true;
		} 
		else if (speedometer.speed < speedLimit) {
			WarringMessgeText.SetActive (false);
			aboveSpeed =false;
		} 
		else if (speedometer.speed > speedLimitPause) {
			WarringScreen.SetActive (true);
			aboveSpeed =true;

			CarUserControl carController = Car.GetComponent<CarUserControl> ();
			carController.enabled = false;
		}
	}
}
