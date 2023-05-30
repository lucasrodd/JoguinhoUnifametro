using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCarro : MonoBehaviour
{
    public GameObject CarroPrincipal;
    public float velocidadeMovimentoCarro;

    //float fator = 3;
    public float anguloDeGiro;

    void FixedUpdate()
    {
        float giroEmEixoZ = 0;
        transform.Translate(Vector3.right *
                            Input.GetAxis("Horizontal") *
                            velocidadeMovimentoCarro *
                            Time.deltaTime
                            );

        giroEmEixoZ = Input.GetAxis("Horizontal") * -anguloDeGiro;
        CarroPrincipal.transform.rotation = Quaternion.Euler(0, 0, giroEmEixoZ);

        // Reseting the position
        if (CarroPrincipal.transform.position.y < -4.3f ||
            CarroPrincipal.transform.position.x > 10f ||
            CarroPrincipal.transform.position.x < -10f)
        {
            ResetPosition();
        }
    }

    void ResetPosition()
    {
        CarroPrincipal.transform.position = new Vector3(0f, -2.4f, 0f);
    }
}
