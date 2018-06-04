using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class CrossTrafficLightTrigger : MonoBehaviour {
	public GameObject CrossedTrafficScreen;
	public GameObject Car;

	void OnTriggerEnter (Collider other)
	{
		GameObject YellowLightgGO = GameObject.Find ("Yellow Light");
		Light YellowLight = YellowLightgGO.GetComponent<Light> ();
		GameObject MainUICanvas = GameObject.Find ("MainUICanvas");
		LevelNineObjectives lvl9 = MainUICanvas.GetComponent<LevelNineObjectives> ();

		if (other.gameObject.CompareTag ("Player")) {
			lvl9.isStopped = true;
			if (YellowLight.enabled == false) {
				CrossedTrafficScreen.SetActive (true);
				CarUserControl carController = Car.GetComponent<CarUserControl> ();
				carController.enabled = false;

			} 
			else if (YellowLight.enabled == true) {
				lvl9.isCrossTrafficLights_Right = true;

			}

		}
	}
}
