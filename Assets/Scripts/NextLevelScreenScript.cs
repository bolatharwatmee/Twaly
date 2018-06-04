using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevelScreenScript : MonoBehaviour {
	private int currentLevel;

	public void nextLevelButton(){
		currentLevel = Application.loadedLevel;
		Application.LoadLevelAsync(currentLevel+1);
		//SceneManager.LoadScene(currentLevel);
	}
}
