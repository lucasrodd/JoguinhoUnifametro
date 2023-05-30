using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcenCarreteras : MonoBehaviour
{
    public GameObject motorCarretera;
    public MotorCarreteras motorCarreterasScript;
    public GameObject carroPrincipal;

    void Start()
    {
        motorCarretera = GameObject.Find("MotorCarreteras");
        motorCarreterasScript = motorCarretera.GetComponent<MotorCarreteras>();
    }

    void OnTriggerEnter2D(Collider2D cInfo)
    {
        if(cInfo.gameObject.tag == "Carro")
        {
            motorCarreterasScript.SpeedArcen();
            carroPrincipal.GetComponent<AudioSource>().pitch = 1f;
        }
    }

    void OnTriggerExit2D(Collider2D cInfo)
    {
        if (cInfo.gameObject.tag == "Carro")
        {
            motorCarreterasScript.SpeedCarretera();
            carroPrincipal.GetComponent<AudioSource>().pitch = 1.6f;
        }
    }
}
