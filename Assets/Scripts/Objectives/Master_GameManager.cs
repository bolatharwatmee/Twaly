using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class Master_GameManager : MonoBehaviour {
	
	public CarUserControl carUserControl;
	public SteeringWheel SteeringWheel;


	void Start(){
		carUserControl = GetComponent<CarUserControl> ();
		SteeringWheel = GetComponent<SteeringWheel> ();

		carUserControl.enabled = false;
		AudioListener.pause = true;
		SteeringWheel.enabled = false;

	}




}
