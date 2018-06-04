using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLevel : MonoBehaviour {
	int currentLevel;
	public void RestartLevelButtonClicked(){
		ScoreCounter.ScoreValue = 0;
		currentLevel = Application.loadedLevel;
		Application.LoadLevelAsync(currentLevel);
	}
}
