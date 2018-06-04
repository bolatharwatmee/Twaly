using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedOmeter : MonoBehaviour {
	public Rigidbody rb;
	private double sp;
	public int speed;
	public Text SpeedText;
	public static int SpeedPublic;

	void Start(){
		//SpeedText = GetComponent<Text> ();
		rb = GetComponent<Rigidbody> ();
		speed = 0;
		SpeedText.text = speed.ToString ()+" KM";
	}
	// Update is called once per frame
	void Update () 
	{    
		sp = rb.velocity.magnitude * 3.6;
		speed = Mathf.RoundToInt ((float)sp);
		SpeedPublic =  Mathf.RoundToInt ((float)sp);
		SpeedText.text = speed.ToString ()+" KM";
	}
}
