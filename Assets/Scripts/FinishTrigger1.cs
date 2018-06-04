using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class FinishTrigger1 : MonoBehaviour {
	public static bool secoundTrigger;
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			secoundTrigger = true;
		}
	}
}
