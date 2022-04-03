using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class yemCollect : MonoBehaviour
{
    /*burayı dikkate alma
    public static yemCollect Instance;
    void Awake()
    {
        Instance = this;
    }
    */
    private AudioSource yendi;
    public GameObject completeLevelUI;

    public int yem = 0;

    public Text yemText;
   /* void onTriggerEnter2D (Collider2D other){
        if(other.gameObject.CompareTag("Yem")){
            Destroy(other.gameObject);
        }
    */

    
    void Start()
    {
        yemText.text=yem.ToString() + "/10 SEEDS";
        completeLevelUI.SetActive(false);
        yendi = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Yem"))
        {
            Destroy(other.gameObject);
            yendi.Play();
            yem += 1;
            Debug.Log("yemcollect " + yem);
            yemText.text=yem.ToString() + "/10 SEEDS";
        }

        if (yem >= 10)
        {
            completeLevel();
        }
    }
    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
        
        /*win sahnesini eskiden boyle çağırıyodum - ucLevelcomplete diye bir script yaptım şimdi orada
        if (SceneManager.GetActiveScene().buildIndex >= 3)
        {   
            SceneManager.LoadScene("winScene-fistik");
        }
    */
    }
}
