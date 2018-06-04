using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Accessibility;
using UnityStandardAssets.Vehicles.Car;



public class levelOneObjectives : MonoBehaviour {
	public GameObject[] ObjectivesTickesNumbers;
	public GameObject NextLevelScreen;
	public GameObject ObjectivesScreen;
	public GameObject Car;


	public bool isTurnedRight = false;
	public bool isTurnedLeft = false;
	public bool isStopped = false;
	public bool isMoveForward = false;
	public bool isMoveBackward = false;




	void Update(){
		CarUserControl carUserController = Car.GetComponent<CarUserControl>();
		CarController carController = Car.GetComponent<CarController> ();

		if (isTurnedRight == true) {
			ObjectivesTickesNumbers [0].SetActive (true);
		}
		if (isTurnedLeft == true) {
			ObjectivesTickesNumbers [1].SetActive (true);
		}
		if (stopped () == true) {
			ObjectivesTickesNumbers [2].SetActive (true);
		}
		if (isMoveBackward == true) {
			ObjectivesTickesNumbers [3].SetActive (true);
		}
		
		if (isTurnedRight == true && isTurnedLeft == true && stopped () == true && isMoveBackward == true) {
			ObjectivesScreen.SetActive (false);
			NextLevelScreen.SetActive (true);
			carUserController.enabled = false;
			carController.enabled = false;		}
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
