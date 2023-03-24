using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject obstaculoobj;
    [SerializeField] GameObject potionobj;
    float dificuldade = 5;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("spawn");//inicia codigos abaixo
        StartCoroutine("time");//inicia codigos abaixo
        StartCoroutine("potion");//inicia codigos abaixo
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawn()//executa ação a cada certo tempo
    {
        yield return new WaitForSeconds(Random.Range(dificuldade,(dificuldade-2)));// aguarda um tempo aleatorio entre dificuldade e dificuldade-2 antes de executar o proximo codigo
        Instantiate(obstaculoobj, transform.position,Quaternion.identity);// cria um objeto partindo de um prefab
        StartCoroutine("spawn");//reinicia este codigo 

    }
    IEnumerator potion()//executa ação a cada certo tempo
    {
        yield return new WaitForSeconds(15);// aguarda um tempo de 15 segundos antes de executar o proximo codigo
        Instantiate(potionobj,new Vector2(10.2f, -2.2f), Quaternion.identity);// cria um objeto partindo de um prefab
        StartCoroutine("potion");//reinicia este codigo 

    }
    IEnumerator time()//executa ação a cada certo tempo
    {
        yield return new WaitForSeconds(15);// aguarda um tempo de 15 segundos antes de executar o proximo codigo
        if (dificuldade >= 2) { dificuldade -= 1; }// diminui o float dificuldade em 1

        StartCoroutine("time");//reinicia este codigo 

    }


}
