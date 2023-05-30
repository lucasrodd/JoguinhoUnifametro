using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PopInicio : MonoBehaviour
{
    public Image BGpop;
    public Image imgPop;
    public Button botaoContinuar;
    public GameObject popInicioGO;
    public ContagemRegressiva contagemRegressivaScript;

    public void fecharPop()
    {
        contagemRegressivaScript.IniciarContagemRegressiva();
        BGpop.CrossFadeAlpha(0,0.3f,false);
        imgPop.CrossFadeAlpha(0,0.3f,false);
        botaoContinuar.gameObject.SetActive(false);
    }
}
