using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blinkers : MonoBehaviour {
	public GameObject RightBlinker;
	public GameObject leftBlinker;
	public static bool isRight = false;
	public static bool isLeft = false;

	public void Start(){
		StartCoroutine (Delay ());
	}

	void Update () {
		//R1 Button joystickbutton4
		if (Input.GetKey (KeyCode.JoystickButton4)) {
			leftBlinker.SetActive (true);
			isLeft = true;
			//Debug.Log ("Worled 1");
		}
		//L1 Button joystickbutton5
		else if (Input.GetKey (KeyCode.JoystickButton5)) {
			RightBlinker.SetActive (true);
			isRight = true;
			Debug.Log ("Worled 1");
		}
	}

	IEnumerator Delay(){
		while (true) {
			yield return new WaitForSeconds (8);
			leftBlinker.SetActive (false);
			RightBlinker.SetActive (false);
		}
	}
}
