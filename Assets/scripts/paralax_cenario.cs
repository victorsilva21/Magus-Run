using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralax_cenario : MonoBehaviour
{
    public Renderer quad; // seta o componente renderer no codigo
    public float vel = 0.5f;

    // seta uma variavel de numero quebrado
    // Start is called before the first frame update
    void Start()
    {
        quad = gameObject.GetComponent<Renderer>();// pega o componente do objeto
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(vel * Time.deltaTime, 0);// cria um vetor com nome offset, para mover a textura
        quad.material.mainTextureOffset += offset; // transforma a textura de acordo ao vetor

    }
}
