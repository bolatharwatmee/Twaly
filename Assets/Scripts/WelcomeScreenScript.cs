using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;


public class WelcomeScreenScript : MonoBehaviour {
	public GameObject WelcomeScreen;
	public GameObject ObjectivesScreen;
	public GameObject PauseButton;
	public GameObject Car;
	public GameObject SteeringWheel;
	//public AudioSource carAudio;


	//public AudioSource welcomeVoiceOver;

	void Start(){
		CarUserControl carController = Car.GetComponent<CarUserControl>();
		SteeringWheel steeringWheel = SteeringWheel.GetComponent<SteeringWheel>();



		carController.enabled = false;
		PauseCarSound (true);
		//welcomeVoiceOver.Play ();
		steeringWheel.enabled = false;


	}

	public void disappearButton(){
		CarUserControl carController = Car.GetComponent<CarUserControl>();
		SteeringWheel steeringWheel = SteeringWheel.GetComponent<SteeringWheel>();

		WelcomeScreen.SetActive(false);
		ObjectivesScreen.SetActive(true);
		PauseButton.SetActive (true);

		carController.enabled = true;
		PauseCarSound (false);
		//welcomeVoiceOver.Play ();
		steeringWheel.enabled = true;

	}

	public void PauseCarSound(bool isPaused){
		if (isPaused == true) {
			AudioSource[] allaudio = Car.GetComponents<AudioSource> ();
			for (int x =0 ; x < 3; x++) {
				allaudio [x].Pause ();
			}
		}
		else if (isPaused == false) {
			AudioSource[] allaudio = Car.GetComponents<AudioSource> ();
			for (int x =0; x < 3; x++) {
				allaudio [x].Play ();
			}
		}
	}

}

