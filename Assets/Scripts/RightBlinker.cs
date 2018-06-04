using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBlinker : MonoBehaviour {
	public static bool RightTriggered ;
	void OnTriggerStay (Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			if (Blinkers.isRight == true) {
				RightTriggered = true;
			}
		}
	}
}
