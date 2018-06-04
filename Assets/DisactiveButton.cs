using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisactiveButton : MonoBehaviour {
	public GameObject CurrentButton;
	public GameObject NextButton;

	public void DisableButton(){
		CurrentButton.SetActive (false);
		NextButton.SetActive (true);
	}
}
