using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBook : MonoBehaviour {
	public GameObject[] Pages;
	private int n=0 ;
	private static int counter = 0;



	void Update(){
		n = counter;
		Debug.Log ("n=" + n);
	}
	public void NextPage(){

		Pages [n+1].SetActive (true);
		Pages [n].SetActive (false);
		counter = counter + 1;
	}
	public void PreviousPage(){

		Pages [n-1].SetActive (true);
		Pages [n].SetActive (false);
		counter = counter - 1;
	}
}
