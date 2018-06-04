using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour {

	public GameObject CurrentQuestion;
	public GameObject SecondQuestion;
	public Image wrongAnswer;
	//public Text ScoreUI;
	public int Score1;
	public int total;


	public void Start(){
		StartCoroutine (Delay ());
	}

	public void RightAnswer_Onclick () { 
		ScoreCounter.ScoreValue += 1;
		CurrentQuestion.SetActive (false);
		SecondQuestion.SetActive (true);

	}
	public void WrongAnswer_OnClick(){
		//display Wrong UI
		//delay
		wrongAnswer.enabled=true;
		CurrentQuestion.SetActive (false);
		SecondQuestion.SetActive (true);
	}



	IEnumerator Delay(){
		while (true) {
			yield return new WaitForSeconds (2);
			wrongAnswer.enabled = false;
		}
	}
}
