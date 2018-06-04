using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
	public static int ScoreValue;
	public Text Score;


	
	// Update is called once per frame
	void Update () {
		Score.text = ScoreValue.ToString();	
	}
}
