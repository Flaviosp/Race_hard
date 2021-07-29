using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveEnemy : MonoBehaviour
{
    private Text score;


    // Start is called before the first frame update
    void Start()
    {
        //Pegando o score da tela
        score = GameObject.Find("Canvas").transform.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movendo inimigo na velocidade de 0.1 a 0.2
        transform.position += new Vector3(0, Random.Range(-0.1f, -0.2f), 0);
        if (transform.position.y <= -7.13f)
        {
            MovePlayer.score++;
            score.text = MovePlayer.score.ToString();
            Destroy(this.gameObject);
            

        }

    }
}
