using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuButtonExam : MonoBehaviour {

	public GameObject PauseScreen;

	public void PauseMenuClicked(){
		PauseScreen.SetActive (true);
	}
}
