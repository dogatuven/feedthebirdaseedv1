using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zararliCollect : MonoBehaviour
{
    // Start is called before the first frame update
    /* void OnTriggerEnter2D (Collider2D other){
        if (other.gameObject.CompareTag("zararli")){
            Destroy(other.gameObject);
        }
    }
    */

    public void OnCollisionEnter2D (Collision2D other){
        if (other.gameObject.CompareTag("zararli"))
        {
            SceneManager.LoadScene("GameOver-fistik");
            Debug.Log("gameover");
        }
    }
}
