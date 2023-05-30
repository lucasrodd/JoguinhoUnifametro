using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Veneno : MonoBehaviour
{
    public GameObject VidasGO;
    public Vidas vidasScript;

    void Start()
    {
        VidasGO = GameObject.Find("Vidas");
        vidasScript = VidasGO.GetComponent<Vidas>();
    }

    void OnTriggerEnter2D(Collider2D cInfo)
    {
        if (cInfo.gameObject.tag == "Carro")
        {
            vidasScript.contadorVidas = vidasScript.contadorVidas -1;
            vidasScript.ImagemMenosVida();
            gameObject.SetActive(false);
        }
    }
}
