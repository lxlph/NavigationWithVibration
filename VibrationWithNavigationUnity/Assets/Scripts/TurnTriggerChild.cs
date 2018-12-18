using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTriggerChild : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.GetComponentInParent<TurnTriggerScript>().collideAction(gameObject.name);
        }
    }
}
