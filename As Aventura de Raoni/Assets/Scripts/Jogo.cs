using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jogo : MonoBehaviour
{
    private int pontos;
    public Text pontosText;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("pontos"))
        {
            AtualizarPontos();
            pontos = PlayerPrefs.GetInt("pontos");
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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CarregaFase1()
    {
        PlayerPrefs.SetInt("pontos",0);
        SceneManager.LoadScene("Fase1");
    }

    public void CarregaFase2()
    {
        SceneManager.LoadScene("Fase2");
    }


    public void CarregaIntroducao(){
        SceneManager.LoadScene("Introducao");
    }

    public void EncerrarJogo(){
        Application.Quit();
    }
}
