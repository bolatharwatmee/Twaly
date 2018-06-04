using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class PauseButton : MonoBehaviour {
	public GameObject PauseMenu;
	//public GameObject ObjectivesMenu;
	//public GameObject pauseButton;
	public GameObject Car;
	public GameObject SteeringWheel;

	public void PauseButtonClicked(){
		CarUserControl carUserController = Car.GetComponent<CarUserControl>();
		CarController carController = Car.GetComponent<CarController> ();
		SteeringWheel steeringWheel = SteeringWheel.GetComponent<SteeringWheel>();

		carUserController.enabled = false;
		carController.enabled = false;
		//AudioListener.pause = true;
		steeringWheel.enabled = false;

		PauseMenu.SetActive (true);
		//ObjectivesMenu.SetActive (false);
		//pauseButton.SetActive (false);

	}
}
