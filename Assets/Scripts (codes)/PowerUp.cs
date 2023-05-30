using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject CronometroGO;
    public Cronometro cronometroScript;

    void Start()
    {
        CronometroGO = GameObject.Find("Cronometro");
        cronometroScript = CronometroGO.GetComponent<Cronometro>();
    }

    void OnTriggerEnter2D(Collider2D cInfo)
    {
        if(cInfo.gameObject.tag == "Carro")
        {
            cronometroScript.tempo += 10;
            cronometroScript.ImagemMaisTempo();
            gameObject.SetActive(false);
        }
    }
}
