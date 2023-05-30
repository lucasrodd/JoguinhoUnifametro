using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cronometro : MonoBehaviour
{

    public GameObject motorCarretera;
    public MotorCarreteras motorCarreterasScript;

    public TextMeshProUGUI textoTempo, textoMetros;
    
    public float distancia, tempo;

    public bool cronometroLigado;

    public Image maisTempo;

    public GameObject popGameOverGO;
	public PopGameOver popGameOverScript;

    void Start()
    {
        textoTempo.text = "1:30";
        textoMetros.text = "0";
        maisTempo.CrossFadeAlpha(0, 0, false);
    }

    void Update()
    {
        if ( motorCarreterasScript.jogoFinalizado == false && cronometroLigado == true )
        {
            distancia += Time.deltaTime * motorCarreterasScript.speed;
            textoMetros.text = ((int)distancia).ToString();

            tempo -= Time.deltaTime;
            int minutos = (int)tempo / 60;
            int segundos = (int)tempo % 60;

            textoTempo.text = minutos.ToString() + ":" + segundos.ToString().PadLeft(2, '0');
        }

        if ( motorCarreterasScript.jogoFinalizado == false && tempo <= 0.00f )
        {
            motorCarreterasScript.jogoFinalizado = true;
            popGameOverGO.SetActive(true);
			popGameOverScript.AtivarGameOver();
        }
    }

    public void ImagemMaisTempo()
    {
        maisTempo.CrossFadeAlpha(1,0.5f,false);
        this.gameObject.GetComponent<AudioSource>().Play();
        StartCoroutine(FechaImagemMaisTempo());
    }

    IEnumerator FechaImagemMaisTempo()
    {
        yield return new WaitForSeconds(1);
        maisTempo.CrossFadeAlpha(0,0.5f,false);
    }
}
