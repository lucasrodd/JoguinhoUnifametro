using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotaoCenas : MonoBehaviour
{

    void OnMouseDown()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.3f,0.3f,0.3f,1);
        this.gameObject.GetComponent<AudioSource>().Play();
    }
    void OnMouseOver()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5f,0.5f,0.5f,1);
    }
    void OnMouseExit()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
    }
    public void OnMouseUp()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;

        StartCoroutine(CarregarCena());
    }

    IEnumerator CarregarCena()
    {
        yield return new WaitForSeconds (1);
        SceneManager.LoadScene("MainScene");
    }
}
