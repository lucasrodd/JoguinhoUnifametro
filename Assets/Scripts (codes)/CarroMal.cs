using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroMal : MonoBehaviour
{
    public GameObject motorCarretera;
    public MotorCarreteras motorCarreterasScript;
    public GameObject carroPrincipal;

    void Start()
    {
        motorCarretera = GameObject.Find("MotorCarreteras");
        motorCarreterasScript = motorCarretera.GetComponent<MotorCarreteras>();
    }

    void OnCollisionEnter2D(Collision2D cInfo)
    {
        if(cInfo.gameObject.tag == "Carro")
        {
            motorCarreterasScript.SpeedCarroMal();
            carroPrincipal.GetComponent<AudioSource>().pitch = 1f;
        }
    }

    void OnCollisionExit2D(Collision2D cInfo)
    {
        if (cInfo.gameObject.tag == "Carro")
        {
            motorCarreterasScript.SpeedCarretera();
            carroPrincipal.GetComponent<AudioSource>().pitch = 1.6f;
        }
    }
}
