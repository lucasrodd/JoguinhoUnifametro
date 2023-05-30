using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public GameObject[] vidas;
    public int contadorVidas = 3;
    public GameObject popGameOverGO;
    public PopGameOver popGameOverScript;
    public GameObject motorCarretera;
    public MotorCarreteras motorCarreterasScript;
    public Cronometro cronometroScript;
    public Image menosVida;

    void Start () {
        menosVida.CrossFadeAlpha(0,0,false);
    }

    void Update () {

        if (contadorVidas == 2 && motorCarreterasScript.jogoFinalizado == false)
        {
            vidas[2].SetActive(false);
        }
        if(contadorVidas == 1)
        {
            vidas[1].SetActive(false);
        }
        if (contadorVidas == 0 && motorCarreterasScript.jogoFinalizado == false)
        {
            vidas[0].SetActive(false);
            motorCarreterasScript.jogoFinalizado = true;
            cronometroScript.cronometroLigado = false;
            popGameOverGO.SetActive(true);
            popGameOverScript.AtivarGameOver();
        }

    }

    public void ImagemMenosVida()
    {
        if(contadorVidas >= 1)
        {
            menosVida.CrossFadeAlpha(1,0.5f,false);
            this.gameObject.GetComponent<AudioSource>().Play();
            StartCoroutine(FecharImagemMenosVida());
        }
    }

    IEnumerator FecharImagemMenosVida()
    {
        yield return new WaitForSeconds(1);
        menosVida.CrossFadeAlpha(0,0.5f,false);
    }
}
