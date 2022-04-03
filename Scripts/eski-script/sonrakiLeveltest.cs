using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sonrakiLeveltest : MonoBehaviour
{
    public void replayLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

}
