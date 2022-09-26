using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float JumpForce;
    public int health = 5;
    public bool isGrounded;
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
            RB.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}

