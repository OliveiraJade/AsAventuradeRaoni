using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jogo : MonoBehaviour
{
    private int pontos;
    public Text pontosText;

    public int vidas = 3;
    public Text vidaText;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("pontos"))
        {
            AtualizarPontos();
            pontos = PlayerPrefs.GetInt("pontos");
        }

        if (PlayerPrefs.HasKey("vidas"))
        {
            AtualizarVida();
            vidas = PlayerPrefs.GetInt("vidas");
        }


    }

    void AtualizarPontos()
    {
        pontosText.text = "Pontos: " + PlayerPrefs.GetInt("pontos");
    }

    public void AdicionarPontos()
    {
        pontos++;
        PlayerPrefs.SetInt("pontos", pontos);
        AtualizarPontos();
    }

    public void AumentarVida()
    {
        vidas++;
        PlayerPrefs.SetInt("vidas", vidas);
    }

    public void DiminuirVida()
    {
        vidas--;
        PlayerPrefs.SetInt("vidas", vidas);
        AtualizarVida();
    }

    void AtualizarVida()
    {
        if (vidas < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            vidaText.text = "Vidas: " + PlayerPrefs.GetInt("vidas");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void CarregaFase1()
    {
        PlayerPrefs.SetInt("pontos", 0);
        PlayerPrefs.SetInt("vidas", 3);
        SceneManager.LoadScene("Fase1");
    }

    public void CarregaFase2()
    {

        SceneManager.LoadScene("Fase2");
    }




    public void CarregaIntroducao()
    {
        SceneManager.LoadScene("Introducao");
    }

    public void CarregaCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }


    public void CarregaMenuInicial()
    {
        SceneManager.LoadScene("MenuInicial");
    }


    public void EncerrarJogo()
    {
        Application.Quit();
    }
}
