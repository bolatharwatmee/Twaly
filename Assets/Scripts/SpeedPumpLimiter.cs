using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPumpLimiter : MonoBehaviour {
	public int speed = 30;
	public static bool isGoodSpeed = false;
	public static bool isAboveSpeed = false;
	public GameObject Car;
	public GameObject SpeedPumbScreen;

	void OnTriggerEnter (Collider other1){
		
		if (other1.gameObject.CompareTag ("Player")) {
			//GameObject Car = GameObject.Find ("Car");
			SpeedOmeter speedometer = Car.GetComponent<SpeedOmeter> ();
			int currentSpeed = speedometer.speed;

			if (currentSpeed < speed) {
				isGoodSpeed = true;
			} else if (currentSpeed > speed) {
				isAboveSpeed = true;
			}
		}
		if (isAboveSpeed == true) {
			SpeedPumbScreen.SetActive (true);
		}
	}
}
