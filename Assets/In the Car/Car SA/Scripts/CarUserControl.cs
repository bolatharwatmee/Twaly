using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
		float currentGear = 0f;



        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

		public float Gears (){
			if (Input.GetAxis ("GearDown")>0.5f && currentGear >=-1f)
			{ currentGear = currentGear - 1f; 
			} 
			else if (Input.GetAxis ("GearUp")>0.5f && currentGear <=1f) 
			{ currentGear = currentGear + 1f; 
			} 
			return currentGear;

		}


        private void FixedUpdate()
        {



			if (Input.GetAxis ("GearDown")>0.5f && currentGear >=-1f)
			{ currentGear = currentGear - 1f; 
			} 
			else if (Input.GetAxis ("GearUp")>0.5f && currentGear <=1f) 
			{ currentGear = currentGear + 1f; 
			} 

            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            //float v = CrossPlatformInputManager.GetAxis("Vertical");

			Debug.Log (currentGear);
			bool speed = CrossPlatformInputManager.GetButton ("Speed");
			float v = 0f;
			if (speed)
				v =currentGear* 1;






#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
