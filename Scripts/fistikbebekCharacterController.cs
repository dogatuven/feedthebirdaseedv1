using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class fistikbebekCharacterController : MonoBehaviour
{
    // Components
    public float speed = 0.0f;
    public float eat = 0.0f;
    public Animator _animator;
    public Rigidbody2D r2d;
    public Vector3 fistikPosition;

    // Player
    public float walkSpeed= 2.0f;
    //alttaki satırda limit olmasın diye 2 yaptım, diğer türlü çapraz giderken yavaş oluyor
    public float speedLimit=2.0f;
    public float inputHorizontal;
    public float inputVertical;

    //anim
    string currentState;
    const string FISTIKBEBEKEATING = "fistikbebekeating";



    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        r2d = GetComponent<Rigidbody2D>();
        fistikPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //sağ sol yukarı aşağı hrk için
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
        
        /*
        //sağ sol için hız
        if (Input.GetKey(KeyCode.A)){
            speed = 1.0f;
        }
        else {
            speed = 0.0f;
        }

        _animator.SetFloat("speed", speed);
        r2d.velocity = new Vector2 (speed, 0.0f);
        */

        _animator.SetFloat("speed", speed);

        /*
        if(Input.GetAxis("Vertical") == 0.0f){
            _animator.SetFloat("speed", 0.0f);
        } else if (Input.GetAxis("Vertical") != 0.0f) {
            _animator.SetFloat("speed", 1.0f);
        } */

        if (Input.GetAxis("Horizontal") != 0.0f || Input.GetAxis("Vertical") != 0.0f) {
            _animator.SetFloat("speed", 2.0f);
        } else if(Input.GetAxis("Horizontal") == 0.0f || Input.GetAxis("Vertical") == 0.0f){
            _animator.SetFloat("speed", 0.0f);
        } 

        // sprite yansıtma
        if (Input.GetAxisRaw("Horizontal") == -1){
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        } else if (Input.GetAxisRaw("Horizontal") == 1) {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }


        //yem yerken mouse sol tuş - float (KÖTÜ)
        if (Input.GetKey(KeyCode.Mouse0)){
            eat = 1.0f;
        }
        else {
            eat = 0.0f;
        }
        _animator.SetFloat("eat", eat);
    
    }
        
    void FixedUpdate()
    {
        if (inputHorizontal != 0 || inputVertical != 0) {

            if(inputHorizontal != 0 && inputVertical != 0)
            {
                inputHorizontal *= speedLimit;
                inputVertical *= speedLimit;
                _animator.SetFloat("speed", speed);
            }


            r2d.velocity =  new Vector2(inputHorizontal*walkSpeed, inputVertical*walkSpeed);
            _animator.SetFloat("speed", speed);
        }
        else {
            r2d.velocity = new Vector2(0f,0f);
            _animator.SetFloat("speed", speed);

        }
    }

    //animation state change
    /*public void ChangeAnimationState(string newState) {
        if()
        {

        }
    }*/
}