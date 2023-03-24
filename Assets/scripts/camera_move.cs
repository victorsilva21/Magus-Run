using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using info;

public class camera_move : MonoBehaviour
{
    public bool movimento = false;
    public GameObject canvas2;
    [SerializeField] GameObject spawner;
    contador_score score;
    // Start is called before the first frame update
    private void Awake()
    {
        score = GameObject.Find("hud padrao").GetComponent<contador_score>();
        spawner = GameObject.Find("spawner");
        spawner.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey) // inicia os outros codigos ao qualquer tecla ser clicada
        {
            movimento = true;

        }
        if(movimento==true && this.gameObject.transform.position.y != 0) // enquanto a posição y não for zero, a camera se moverá nessa direção
        {
            score.score = 0;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0,-10), 10 * Time.deltaTime);

        }
        else if(movimento == true && canvas2 == true) // quando a camera ja estiver na posição zero, ativa o canvas2.
        {

            canvas2.SetActive(true);
            spawner.SetActive(true);
        }
    }

}
