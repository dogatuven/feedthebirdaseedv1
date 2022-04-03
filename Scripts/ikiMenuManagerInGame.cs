using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ikiMenuManagerInGame : MonoBehaviour
{
    /*
    bu kod, ikinci leveldaki menuler için, 
    yani her levelda tekrar yaz, sayıyı değiştir
    kod btk akademi unity giriş eğitiminden
    */
    public GameObject InGameScreen, PauseScreen; //unityde eklenilen emptyler

    // Start is called before the first frame update
    void Start()
    {
        InGameScreen.SetActive(true);
        
    }

    //her buton için bi kod parçası
    public void PauseButton()
    {
        Time.timeScale=0;
        InGameScreen.SetActive(false);
        PauseScreen.SetActive(true);
    }
    public void PlayButton()
    {
        Time.timeScale=1;
        InGameScreen.SetActive(true);
        PauseScreen.SetActive(false);
    }
    public void ReplayButton()
    {
        //loadscene sırasını değiştir
        Time.timeScale=1;
        SceneManager.LoadScene(2);
        
    }
    public void HomeButton()
    {
        //loadscene sırasını değiştir
        Time.timeScale=1;
        SceneManager.LoadScene(0);
        
    }
}
