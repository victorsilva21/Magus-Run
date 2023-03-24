using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas_inicial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey) //destroi o canvas ao qualquer tecla ser clicada
        {
            Destroy(this.gameObject);
        }
    }
}
