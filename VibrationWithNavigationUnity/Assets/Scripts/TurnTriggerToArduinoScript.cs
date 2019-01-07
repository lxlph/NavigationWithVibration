using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTriggerToArduinoScript : MonoBehaviour
{

    //public SerialController serialController;
    private int vibrationMethodNumber = 1;

    void Start()
    {
        //serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
    }

    public void setVibrationMethod(int number)
    {
        vibrationMethodNumber = number;
    }

    public void vibrateLeft()
    {
        if(vibrationMethodNumber == 1)
        {
            vibrateLeft_onehanded();
        }
        else
        {
            vibrateLeft_twohanded();
        }
    }

    public void vibrateRight()
    {
        if (vibrationMethodNumber == 1)
        {
            vibrateRight_onehanded();
        }
        else
        {
            vibrateRight_twohanded();
        }
    }

    private void vibrateLeft_onehanded()
    {
        //serialController.SendSerialMessage("V");
    }

    private void vibrateRight_onehanded()
    {
        //serialController.SendSerialMessage("B");
    }

    private void vibrateLeft_twohanded()
    {
        //serialController.SendSerialMessage("N");
    }

    private void vibrateRight_twohanded()
    {
        //serialController.SendSerialMessage("M");
    }
}
