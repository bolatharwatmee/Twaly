using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLeft : MonoBehaviour {
	private GameObject MainCanvas;

	public void OnTriggerEnter (Collider other){
		if (other.gameObject.CompareTag ("Player")) {

			MainCanvas = GameObject.Find ("MainUICanvas");
			levelOneObjectives lvl2 = MainCanvas.GetComponent<levelOneObjectives> ();
			lvl2.isTurnedLeft = true;
			lvl2.isStopped = true;
		}
	}
	public void OnTriggerExit(Collider other1){
		if (other1.gameObject.CompareTag ("Player")) {
			
			MainCanvas = GameObject.Find ("MainUICanvas");
			levelOneObjectives lvl2 = MainCanvas.GetComponent<levelOneObjectives> ();
			lvl2.isMoveBackward = true;
		}
	}

}
