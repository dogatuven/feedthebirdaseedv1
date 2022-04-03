using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public Text yemText;
    
    int yem = 0;


    // Start is called before the first frame update
    void Start()
    {
        yemText.text=yem.ToString() + " SEEDS";
    }

     public void OnTriggerEnter2D (Collider2D other){
        if (other.gameObject.CompareTag("Yem")){
            yem += 1;
            //Debug.Log("yem: " + yem);
            yemText.text=yem.ToString() + " SEEDS";
            Debug.Log("text 1");
        }
     }
}
