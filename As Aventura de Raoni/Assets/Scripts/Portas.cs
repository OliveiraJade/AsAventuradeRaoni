using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portas : MonoBehaviour
{
    private Jogo jogo;

    void Start()
    {
        GameObject objetoJogo = GameObject.FindWithTag("JOGO");
        jogo = objetoJogo.GetComponent<Jogo>();

    }

    private void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Fase2");
        }
    }

}
