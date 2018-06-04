using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
	public GameObject Buttons;
	public GameObject XImage;
	void Update(){
		if (Input.GetAxis ("Horizontal")>0.5f) {
			Buttons.transform.Rotate (0, 90 * Time.deltaTime, 0);	
		}
		else if (Input.GetAxis ("Horizontal")<-0.5f) {
			Buttons.transform.Rotate (0, -90 * Time.deltaTime, 0);	
		}
	}
	public void InfoAppear(){
		XImage.SetActive (true);
	}
	public void InfoDisppear(){
		XImage.SetActive (false);
	}


	public void LevelsButtons(){
		Application.LoadLevelAsync(5);
	}
	public void PracrticalExamButton(){
		Application.LoadLevelAsync(3);
	}
	public void impracrticalExamButton(){
		Application.LoadLevelAsync(2);
	}
	public void BookButton(){
		Application.LoadLevelAsync(1);
	}
	public void FreeButton(){
		Application.LoadLevelAsync(4);
	}
}