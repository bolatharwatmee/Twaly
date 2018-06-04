using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class LevelTenObjectives : MonoBehaviour {
	public GameObject[] ObjectivesTickesNumbers;
	public GameObject NextLevelScreen;
	public GameObject ObjectivesScreen;
	public GameObject Car;
	public GameObject ArrowLeft;
	public GameObject ArrowRight;


	public static bool isStopped;

	void Update () {
		CarUserControl carUserController = Car.GetComponent<CarUserControl>();
		CarController carController = Car.GetComponent<CarController> ();

		if (LeftBlinker.leftTriggered == true) {
			ObjectivesTickesNumbers [0].SetActive (true);
			ArrowLeft.SetActive (false);
			ArrowRight.SetActive (true);
		}
		if (RightBlinker.RightTriggered == true) {
			ObjectivesTickesNumbers [1].SetActive (true);
			ArrowRight.SetActive (false);
		}

		if (stopped () == true) {
			ObjectivesTickesNumbers [2].SetActive (true);
		}
		if (RightBlinker.RightTriggered == true && LeftBlinker.leftTriggered == true && stopped () == true) {
			ObjectivesScreen.SetActive (false);
			NextLevelScreen.SetActive (true);
			carUserController.enabled = false;
			carController.enabled = false;			}
	}

	bool stopped(){
		SpeedOmeter speedometer = Car.GetComponent<SpeedOmeter> ();
		if(speedometer.speed == 0 && isStopped == true){
			return true;
		}
		else{
			return false;
		}
	}
}
