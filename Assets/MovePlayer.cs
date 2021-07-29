using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    
    public static float score;
    public float xMinimo;
    public float xMaximo;
    public GameObject[] heart;
    public int vida = 4;
    public static int scoreAtual;
    public int scoremaximo;
    string nomedaCena;
    public GameObject messageFim;
    public Button Ok;
    public FixedJoystick movejoystick;

    // Start is called before the first frame update
    void Start()
    {
        nomedaCena = SceneManager.GetActiveScene().name;
        score = 0;
    }

    // Update is called once per frame

    void Update()
    {
        //limitando o caminho do player no eixo x
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMinimo, xMaximo), transform.position.y, transform.position.z);

        //Movendo o player atraves do Joystick no eixo x
        gameObject.GetComponent<Transform>().localPosition += new Vector3(movejoystick.Horizontal * 0.4f, 0, 0);

        // Movendo o player pelo teclado
        //if (Input.GetKey("right"))
        //{
        //  transform.position += new Vector3(0.1f, 0, 0);
        //}else if(Input.GetKey("left"))
        //{
        //    transform.position += new Vector3(-0.1f, 0, 0);
        //}
    }



    private void OnCollisionEnter2D(Collision2D col)
    {
        //detectando colisão do player
        if (col.gameObject.tag == "inimigo")

        {

            Destroy(GameObject.FindWithTag("inimigo"));

            switch (vida)
            {
                case 4:

                    transform.position = new Vector3(-0.39f, -3.64f, 0);
                    Destroy(GameObject.Find("heart4"));

                    break;

                case 3:

                    transform.position = new Vector3(-0.39f, -3.64f, 0);
                    Destroy(GameObject.Find("heart3"));

                    break;

                case 2:

                    transform.position = new Vector3(-0.39f, -3.64f, 0);
                    Destroy(GameObject.Find("heart2"));

                    break;

                case 1:

                    transform.position = new Vector3(-0.39f, -3.64f, 0);
                    Destroy(GameObject.Find("heart1"));

                    break;

                default:

                    scoreAtual = (int)MovePlayer.score;
                    ChegarScorer();
                    MostrarPontuacao();

                    break;

            }
            vida--;


        }
    }
    void ChegarScorer()
    {
        if (scoreAtual > scoremaximo)
        {
            scoremaximo = scoreAtual;
            //scoreAtual = 0;
            PlayerPrefs.SetInt(nomedaCena + "recorde", scoremaximo);
        }
    }

    public void MostrarPontuacao()
    {

        Time.timeScale = 0f;
        messageFim.SetActive(true);
        Ok.onClick.AddListener(Pressed);

    }
    void Pressed()
    {
        AdsUnity.showAds = true;
        SceneManager.LoadScene(0);
    }

    
}

