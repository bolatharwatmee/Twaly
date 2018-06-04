using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class ExamObjectives : MonoBehaviour {

	public GameObject[] ObjectivesTickesNumbers;
	public GameObject FinishScreen;
	public GameObject ObjectivesScreen;
	public GameObject Car;

	void Update () {
		CarUserControl carUserController = Car.GetComponent<CarUserControl>();
		CarController carController = Car.GetComponent<CarController> ();

		if (FinishTrigger.firstTrigger == true) {
			ObjectivesTickesNumbers [0].SetActive (true);
		}
		if (FinishTrigger1.secoundTrigger == true) {
			ObjectivesTickesNumbers [2].SetActive (true);
		}
		if (GearsState.gear < 0) {
			ObjectivesTickesNumbers [1].SetActive (true);
		}
		if (FinishTrigger.firstTrigger == true && FinishTrigger1.secoundTrigger == true && GearsState.gear < 0) {
			ObjectivesScreen.SetActive (false);
			FinishScreen.SetActive (true);
			carUserController.enabled = false;
			carController.enabled = false;	
		}
	}
}
