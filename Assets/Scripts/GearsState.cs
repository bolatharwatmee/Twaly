using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
using UnityStandardAssets.CrossPlatformInput;

public class GearsState : MonoBehaviour {
	public Text GearsStateText;
	public CarUserControl carUserControl;
	public static float gear = 0;

	public void Start () {
		carUserControl = GetComponent<CarUserControl> ();
		GearsStateText.text = "P";

	}
	

	public void Update () {
		

		gear = carUserControl.Gears ();
		if (gear > 0) {
			GearsStateText.text = "D";
		} 
		else if (gear == 0) {
			GearsStateText.text = "P";
		} 
		else if (gear < 0) {
			GearsStateText.text = "R";
		}
	}
}
