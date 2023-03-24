using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sair : MonoBehaviour
{
    Button sairbutton;
    
    // Start is called before the first frame update
    void Start()
    {
        sairbutton = GameObject.Find("sair").GetComponent<Button>();// Atribui componente button a variavel sairbutton
        sairbutton.onClick.AddListener(sairretorno);// cria um listener, para executar uma ação quando o botao for clicado
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void sairretorno()
    {
        Debug.Log("saiu");// escreve no console "saiu"
        Application.Quit();//sai do aplicativo
    }

}
