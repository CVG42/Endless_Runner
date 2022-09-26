using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float JumpForce;
    public float jumpTime;
    private float jumpTimeCount;
    public bool isGrounded;
    public bool isJumping;
    public LayerMask ground;
    private Rigidbody2D RB;
    private Collider2D PlayerCollider;


    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        PlayerCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
       isGrounded = Physics2D.IsTouchingLayers(PlayerCollider, ground);
       if(Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
            jumpTimeCount = jumpTime;
            //RB.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            RB.velocity = Vector2.up * JumpForce;
        }

       if(Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if(jumpTimeCount>0)
            {
                RB.velocity = Vector2.up * JumpForce;
                jumpTimeCount -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

       if(Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    }
}

