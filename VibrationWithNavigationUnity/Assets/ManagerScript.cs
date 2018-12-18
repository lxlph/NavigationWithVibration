using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{

    public GameObject car;
    private Vector3 carStartPosition = new Vector3(300,-11f,183);
    private Vector3 carRouteOne = new Vector3(300, -11f, 164);
    public bool setStartPositon = false;
    public bool setRouteOne = false;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (setStartPositon)
        {
            car.transform.position = (carStartPosition);
            setStartPositon = false;
        }

        else if (setRouteOne) {
            car.transform.position = (carRouteOne);
            setRouteOne = false;
        }
        
    }
}
