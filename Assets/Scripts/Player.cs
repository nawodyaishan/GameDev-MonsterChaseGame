using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
     
    // Declaring Private Variables 
    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;
    // private float maxVelocity = 22f;

    private float movementX;
    
    [SerializeField]
    private Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;
    private string WALK_ANIMATION = "walk";

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();

    }


    // Start is called before the first frame update
    void Start() 
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
    }

    // Assigning player speed and movement
    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        
        Debug.Log("Move X Value is : " + movementX);

        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
        
        //class
    }

    // Setting Animations for movement
    void AnimatePlayer()
    {
        if (movementX >= 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
        }
        else if (movementX == 0)
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
        else if (movementX <= 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
        }

        
    }
}
