using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLimitTrigger : MonoBehaviour {
	public GameObject Car;
	public int speed= 60;

	void OnTriggerEnter (Collider other){
		if (other.gameObject.CompareTag ("Player")) {

			SpeedOmeter speedometer = Car.GetComponent<SpeedOmeter> ();
			GameObject MainUICanvas = GameObject.Find ("MainUICanvas");
			LevelTwoObjectives lvl2 = MainUICanvas.GetComponent<LevelTwoObjectives> ();
			lvl2.isStopped = true;	

			int currentSpeed = speedometer.speed;

			if (currentSpeed < speed) {
				lvl2.GoodSpeed = true;	
			}

		}
	}
}
