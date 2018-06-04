using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingTrigger4 : MonoBehaviour {
	public static bool touch = false;
	void OnTriggerEnter (Collider other1){
		if (other1.gameObject.CompareTag ("Player")) {
			touch = true;
		}
	}
	void OnTriggerExit (Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			touch = false;
		}
	}
}