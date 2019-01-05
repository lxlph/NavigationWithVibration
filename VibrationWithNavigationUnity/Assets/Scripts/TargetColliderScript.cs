using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetColliderScript : MonoBehaviour
{
    private GameObject userGameObject;

    public void Start()
    {
        userGameObject = GameObject.Find("User");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            userGameObject.GetComponent<UserDataScript>().showFinishMessage();
        }
    }
}
