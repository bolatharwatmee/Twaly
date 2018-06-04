using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class FinishTrigger : MonoBehaviour {
	public static bool firstTrigger;
	public GameObject LastTrigger;
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			firstTrigger = true;
			LastTrigger.SetActive (true);
		}
	}
}
