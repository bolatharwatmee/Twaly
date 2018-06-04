using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringWheel : MonoBehaviour {
	

	// This is the maximum angle that your ship will rotate to (assign it in editor)
	public float maxAngle = 0;
	// This is the stored angle that your ship is at
	float currentAngle = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// This makes your angle somewhere between -30 and 30 degrees
		float targetAngle = Input.GetAxis("Horizontal") * maxAngle;
		// This makes the interpolation faster when the input is pressed down,
		// making sure that the value is always positive.
		float interpolationSpeed = 1 + (Mathf.Abs(Input.GetAxis("Vertical") * 0));
		// This smoothly sets the current angle based on the input
		currentAngle = Mathf.Lerp(currentAngle, targetAngle, interpolationSpeed);
		// replace this with however you implement the final value
		transform.rotation = Quaternion.Euler(-0, -0, currentAngle);
		transform.localEulerAngles = new Vector3(20,0 , transform.localEulerAngles.z);
	}
}
