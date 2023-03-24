using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using info;//usando elementos de outro codigo, que foi transformado em um namespace

public class morte : MonoBehaviour
{
    Button mortebutton;
    contador_score pontuacao;
    // Start is called before the first frame update
    void Start()
    {
        pontuacao = GameObject.Find("hud padrao").GetComponent<contador_score>();// atribui a variavel pontuaçao componente contador_score
        mortebutton = GameObject.Find("morte").GetComponent<Button>();// atribui a variavel mortebutton o componente button
        mortebutton.onClick.AddListener(reiniciar);// cria um listener que executará sempre que o botao for clicado
        Time.timeScale = 0; // para o tempo, pausando o jogo
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void reiniciar()
    {
        Time.timeScale = 1;//retorna o tempo ao normal
        if(contador_score.highscore< pontuacao.score)//atribui o valor de score ao float highscore, que mantem guardada a informação por ser estatico
        {
            contador_score.highscore = pontuacao.score;
        }
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);// reinicia o jogo
    }
}
