using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRight: MonoBehaviour {
	private GameObject MainCanvas;

	public void OnTriggerEnter (Collider other){	
		if (other.gameObject.CompareTag ("Player")) {

			MainCanvas = GameObject.Find ("MainUICanvas");
			levelOneObjectives lvl1 = MainCanvas.GetComponent<levelOneObjectives> ();
			lvl1.isTurnedRight = true;
		}
	}
	

}
