using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Material redLight;
    public Material greenLight;

    public void blinkRight_onehanded()
    {
        StartCoroutine(enumRight_onehanded());
    }

    public void blinkLeft_onehanded()
    {
        StartCoroutine(enumLeft_onehanded());
    }

    public void blink_twoHanded()
    {
        StartCoroutine(enum_twoHanded());
    }

    IEnumerator enumRight_onehanded()
    {
        gameObject.GetComponent<MeshRenderer>().material = greenLight;
        yield return new WaitForSeconds(.5f);
        gameObject.GetComponent<MeshRenderer>().material = redLight;
        yield return new WaitForSeconds(.5f);
        gameObject.GetComponent<MeshRenderer>().material = greenLight;
        yield return new WaitForSeconds(.5f);
        gameObject.GetComponent<MeshRenderer>().material = redLight;
        yield return new WaitForSeconds(.5f);
        gameObject.GetComponent<MeshRenderer>().material = greenLight;
        yield return new WaitForSeconds(.5f);
        gameObject.GetComponent<MeshRenderer>().material = redLight;
    }

    IEnumerator enumLeft_onehanded()
    {
        gameObject.GetComponent<MeshRenderer>().material = greenLight;
        yield return new WaitForSeconds(.5f);
        gameObject.GetComponent<MeshRenderer>().material = redLight;
        yield return new WaitForSeconds(.5f);
        gameObject.GetComponent<MeshRenderer>().material = greenLight;
        yield return new WaitForSeconds(.5f);
        gameObject.GetComponent<MeshRenderer>().material = redLight;
    }

    IEnumerator enum_twoHanded()
    {
        gameObject.GetComponent<MeshRenderer>().material = greenLight;
        yield return new WaitForSeconds(.5f);
        gameObject.GetComponent<MeshRenderer>().material = redLight;
    }

}
