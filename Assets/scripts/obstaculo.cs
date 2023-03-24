using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    GameObject spawnerobj;
    // Start is called before the first frame update
    void Start()
    {
        spawnerobj = GameObject.Find("spawner");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-12 * Time.deltaTime, 0));//move o objeto no eixo x
    }
    private void FixedUpdate()
    {
        if (Vector3.Distance(spawnerobj.transform.position, this.gameObject.transform.position) > 20)//destroi o projetil quando passa de certa distancia
        {
            Destroy(this.gameObject);
        }
    }
}
