using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas_tutorial : MonoBehaviour
{
    public GameObject hudP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) //desativa o canvas ao tecla W ser clicada
        {
            hudP.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
