using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class OnCollisionEnterTest : MonoBehaviour {
	public GameObject CrashScreen;
	public GameObject CharacterCrashScreen;
	public GameObject Car;
	public GameObject ObjectivesScreen;
	public GameObject PauseButton;

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag=="Colliders") {

			//sound of crash
			CrashScreen.SetActive (true);
			ObjectivesScreen.SetActive (false);
			PauseButton.SetActive (false);

			CarUserControl carUserController = Car.GetComponent<CarUserControl>();
			CarController carController = Car.GetComponent<CarController> ();
			carUserController.enabled = false;
			carController.enabled = false;
		}
		else if (col.gameObject.tag == "AI Characters") {
			CharacterCrashScreen.SetActive (true);
			ObjectivesScreen.SetActive (false);
			PauseButton.SetActive (false);

			CarUserControl carUserController = Car.GetComponent<CarUserControl>();
			CarController carController = Car.GetComponent<CarController> ();
			carUserController.enabled = false;
			carController.enabled = false;
		}
	}
}
