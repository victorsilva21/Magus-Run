using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using poder_info;

public class personage : MonoBehaviour
{
    public Rigidbody2D fisica;
    GameObject morteobj;
     float vel = 500;
    public bool confirma = true;
    poder valor_check;

    // seta velocidade, um bool para confirmar a presença do chao, e coloca o rigidbody 2d como variavel
    void Awake()
    {
        valor_check = this.gameObject.GetComponent<poder>();
        morteobj = GameObject.Find("morte");
        fisica = gameObject.GetComponent<Rigidbody2D>(); //atribui o rididbody 2d do gameobject a variavel fisica
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && confirma==true)  // caso no chao, e "w" for apertado, o personagem adicionara uma força na direção y com velocidade "vel"
        {
            confirma = false;
            fisica.AddForce(new Vector2(0, vel));
        }
        else if(Input.GetKeyDown(KeyCode.W) && confirma == false && valor_check.poder_valor >= 2)// se no ar e o poder for maior que 2 pode pular mais uma vez, e gasta 2 de poder
        {
            fisica.AddForce(new Vector2(0, vel));
            valor_check.poder_valor -= 2;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chao")) //detecta a presença do chao por meio do comparetag, e troca o bool para positivo caso personagem encoste no chao
        {
            confirma = true;
            Debug.Log("pisei");


        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("obstaculo"))// se colidir com obstaculo, morte será ativada
        {
            morteobj.SetActive(true);
        }
    }
}
