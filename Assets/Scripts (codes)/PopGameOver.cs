using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PopGameOver : MonoBehaviour
{
    public Image BGpop;
    public Image imgPop;
    public Button botaoReiniciar;
    public TextMeshProUGUI metrosPercorridos;
    public GameObject popGameOverGO;
    public Cronometro cronometroScript;
    public GameObject musicaJogo;
    public AudioClip musicaGameOver;

    void Start()
    {
        popGameOverGO.SetActive(false);
    }

    public void AtivarGameOver()
    {
        musicaJogo.GetComponent<AudioSource>().clip = musicaGameOver;
        musicaJogo.GetComponent<AudioSource>().Play();
        botaoReiniciar.gameObject.SetActive(true);
        BGpop.CrossFadeAlpha(1,0.3f,false);
        imgPop.CrossFadeAlpha(1,0.3f,false);
        metrosPercorridos.CrossFadeAlpha(1,0.3f,false);
        metrosPercorridos.text = ((int)cronometroScript.distancia).ToString() + "mts";
    }

    public void ReiniciarJogo()
    {
        BGpop.CrossFadeAlpha(1,0.5f,false);
        StartCoroutine(CarregarCena());
    }

    IEnumerator CarregarCena()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MainScene");
    }
}
