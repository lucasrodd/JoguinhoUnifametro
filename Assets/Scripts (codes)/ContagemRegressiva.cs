using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContagemRegressiva : MonoBehaviour
{

    public GameObject motorCarreteras;
    public GameObject musicaJogo;
    public GameObject somStart;
    public GameObject somMotorCarro;
    public GameObject numeros;
    public Sprite[] numerosIMG;

    public MotorCarreteras motorCarreterasScript;
    public Cronometro cronometroScript;

    float tempoEspera = 4;

    public bool pararContagem = false;
    public bool fimContador = false;

    public AudioSource reprodutor;
    public AudioClip[] sonsContador;

    void Start() 
    {
        reprodutor = this.gameObject.GetComponent<AudioSource>();
        //IniciarContagemRegressiva();
    }

    public void IniciarContagemRegressiva()
    {
        StartCoroutine(ComecarContagemRegressiva());
    }

    public IEnumerator ComecarContagemRegressiva()
    {
        somStart.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1);
        InvokeRepeating("Contando", 1.0f, 1.0f);
    }

    void Contando()
    {
        tempoEspera --;

        if(tempoEspera >= 3)
        {
            numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[3];
            reprodutor.clip = sonsContador[0];
            reprodutor.Play();
        }
        if(tempoEspera <= 3 && tempoEspera >= 2)
        {
            numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[2];
            reprodutor.clip = sonsContador[0];
            reprodutor.Play();
        }
        if(tempoEspera <= 2 && tempoEspera >= 1)
        {
            numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[1];
            reprodutor.clip = sonsContador[0];
            reprodutor.Play();
        }
        if(tempoEspera <= 1 && fimContador == false)
        {
            fimContador = true;
            cronometroScript.cronometroLigado = true;
            motorCarreterasScript.contagemRegressivaTermino = true;
            numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[0];
            reprodutor.clip = sonsContador[1];
            reprodutor.Play();

            musicaJogo.GetComponent<AudioSource>().Play();
            somMotorCarro.GetComponent<AudioSource>().Play();
        }
        if(tempoEspera <= 0)
        {
            CancelInvoke();
        }
    }

    void Update()
    {
        if(tempoEspera == 0 && pararContagem == false)
        {
            pararContagem = true;
            numeros.SetActive(false);
        }
    }

}
