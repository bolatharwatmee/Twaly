using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBlinker : MonoBehaviour {
	public static bool leftTriggered = false;
	void OnTriggerStay (Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			if (Blinkers.isLeft == true) {
				leftTriggered = true;
			}
		}
	}
}
