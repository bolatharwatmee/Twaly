using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class ResumeButton : MonoBehaviour {
	public GameObject PauseScreen;
	public GameObject Car;
	public GameObject SteeringWheel;

	public void ResumeButtonClicked(){
		PauseScreen.SetActive (false);

		CarUserControl carUserController = Car.GetComponent<CarUserControl>();
		CarController carController = Car.GetComponent<CarController> ();
		SteeringWheel steeringWheel = SteeringWheel.GetComponent<SteeringWheel>();

		carUserController.enabled = true;
		carController.enabled = true;
		//AudioListener.pause = true;
		steeringWheel.enabled = true;
	}
}
