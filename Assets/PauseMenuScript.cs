using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject PauseGame;
    public void MenuPause()
    {


        if (Time.timeScale == 1f)
            {
            Time.timeScale = 0f;
            }
            else
            {
            Time.timeScale = 1f;

        }
        
    }
}