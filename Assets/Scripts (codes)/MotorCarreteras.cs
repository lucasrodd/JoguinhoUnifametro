using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorCarreteras : MonoBehaviour
{

    public GameObject motorCarreteras;
    public GameObject[] containerVias;

    public float speed;

    public int numSeletorDeVia;
    public int contadorVias = 0;

    public bool contagemRegressivaTermino;
    public bool jogoFinalizado;


    void Start()
    {
        jogoFinalizado = false;
        GameStart();
    }

    public void GameStart()
    {
        //CriaVias();
        SpeedCarretera();
        contagemRegressivaTermino = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ( jogoFinalizado == false && contagemRegressivaTermino ) 
        {
            motorCarreteras.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    public void CriaVias()
    {
        numSeletorDeVia = Random.Range(0, 5);

        GameObject Via = GameObject.Instantiate(containerVias[numSeletorDeVia],
                                                new Vector3( 0, 10, 0 ),
                                                transform.rotation);

        Via.SetActive(true);
        contadorVias ++;
        Via.name = "Via" + contadorVias;
        Via.transform.parent = motorCarreteras.transform;

        GameObject pecaAux = GameObject.Find( "Via" + (numSeletorDeVia - 1) );

        Via.transform.position = new Vector3(
                transform.position.x,
                pecaAux.GetComponent<Renderer>().bounds.size.y +
                pecaAux.transform.position.y,
                pecaAux.transform.position.z
            );
        
    }

    public void SpeedStop()
    {
        speed = 0;
    }

    public void SpeedArcen()
    {
        speed = 5;
    }

    public void SpeedCarretera()
    {
        speed = 15;
    }

    public void SpeedCarroMal()
    {
        speed = 3;
    }

    public void FinalizarJogo()
    {
        SpeedStop();
    }
}
