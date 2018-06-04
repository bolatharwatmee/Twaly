using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoppedTrigger : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			LevelTenObjectives.isStopped = true;
		}
	}
}
