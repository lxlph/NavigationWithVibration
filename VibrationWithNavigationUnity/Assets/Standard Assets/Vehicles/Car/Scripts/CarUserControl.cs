using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            float handbrake = 0;

            float gas = Input.GetAxisRaw("Gas");
            float bremse = Input.GetAxisRaw("Bremse")*-1;


            Debug.Log(bremse);

            
                m_Car.Move(h, gas, bremse, handbrake);
            
        }
    }
}
