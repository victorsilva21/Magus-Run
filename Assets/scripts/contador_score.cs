using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace info{
    public class contador_score : MonoBehaviour
    {
        public float score;
        float tempo;
        public static float highscore;
        [SerializeField] GameObject morteobj;
        [SerializeField] Text scoreH;
        [SerializeField] Text scoreP;
        // Start is called before the first frame update
        void Awake() // trazer informações importantes quando o objeto inicia, seja sendo ativo ou com o inicio da cena/jogo
        {
            morteobj = GameObject.Find("morte");
            score = 0;
           
            tempo = 0;
            morteobj.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            tempo += Time.deltaTime; //acrecimo de tempo
            if (tempo > 1) // acrescimo de pontos de acordo com o tempo
            {
                score += 1;
                tempo = 0;

            }
            scoreP.text = "Score:" + score.ToString();
            scoreH.text = highscore.ToString() + ":High Score";// conversão de int para string, para mostrar a pontuação em tela
        }
    }
}
