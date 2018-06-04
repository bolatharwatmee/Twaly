using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class WrongWayTrigger : MonoBehaviour {
	public GameObject WrongEayScreen;
	public GameObject Car;
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			WrongEayScreen.SetActive (true);
		}
	}
	void OnTriggerExit (Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			WrongEayScreen.SetActive (false);
		}
	}
}
