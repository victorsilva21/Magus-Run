using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace poder_info
{
    public class poder : MonoBehaviour
    {
        [SerializeField] Image poder_barra;
        public float poder_valor;

        // Start is called before the first frame update
        void Start()
        {
            poder_barra = GameObject.Find("barra_preenchimento").GetComponent<Image>();// atribui o componente Image do objeto barra_preenchimento a variavel poder_barra
        }

        // Update is called once per frame
        
        void FixedUpdate() //executa a ação toda vez em determinado tempo 
        {
            poder_barra.fillAmount = poder_valor / 4;// torna o nivel de preenchimento de poder_barra = ao valor de poder_valor dividido por 4
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("item"))//a todo momento em que colidir com objeto com tag "item" poder aumenta em 1
            {
                poder_valor++;
                
                Destroy(GameObject.FindGameObjectWithTag("item"));// destroi objeto com tag item

            }
        }
    }
}
