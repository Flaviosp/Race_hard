using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public GameObject[] heart = new GameObject[4];
    private int life = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Vida_jogador()
    {
         
        switch (life)
        {

            case 4:

                
                heart[4].SetActive(false);
                heart[3].SetActive(true);
                heart[2].SetActive(true);
                heart[1].SetActive(true);
                break;

            case 3:


                heart[4].SetActive(false);
                heart[3].SetActive(false);
                heart[2].SetActive(true);
                heart[1].SetActive(true);
                break;

            case 2:


                heart[4].SetActive(false);
                heart[3].SetActive(false);
                heart[2].SetActive(false);
                heart[1].SetActive(true);
                break;

            case 1:


                heart[4].SetActive(false);
                heart[3].SetActive(false);
                heart[2].SetActive(false);
                heart[1].SetActive(false);
                break;
        }
        life--;
    }
}

