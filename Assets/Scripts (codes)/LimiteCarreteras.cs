using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteCarreteras : MonoBehaviour
{
    public MotorCarreteras motorCarreterasScript;

    public void OnTriggerEnter2D( Collider2D cInfo )
    {
        if ( cInfo.gameObject.tag == "LimiteVias" )
        {
            Destroy(cInfo.transform.parent.gameObject);
            motorCarreterasScript.CriaVias();
            Debug.Log("LimiteCarreteras");
        }
    }
}
