using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mainmenu : MonoBehaviour
{
    MonetizationManager  monetizationManager;
    public void Playgame()
    {
        SceneManager.LoadScene(1);
        MovePlayer.score = 0;
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
        
    }
    public void SendNotification()
    {
        monetizationManager.SendLocalNotification("Volte Logo","Venha bater se recorde");
    }
}
