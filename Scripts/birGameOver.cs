using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class birGameOver : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(1);           
    }
    
    public void HomeButton()
    {
        //başa dön
        Time.timeScale=1;
        SceneManager.LoadScene(0);
        
    }
    
}
