using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingTrigger1 : MonoBehaviour {
	public static bool touch = false;
	public static bool isStopped = false;
	public static bool isParked = false;

	void OnTriggerEnter (Collider other1){
		if (other1.gameObject.CompareTag ("Player")) {
			touch = true;
			isStopped = true;
			if (GearsState.gear == 0) {
				isParked = true;
			}
		}
	}
	void OnTriggerExit (Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			touch = false;
			isStopped = false;
			isParked = false;
		}
	}
}

