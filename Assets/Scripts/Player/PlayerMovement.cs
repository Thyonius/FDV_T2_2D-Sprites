using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;            

    Vector3 movement;                   
    Animator anim;                      
    Rigidbody2D playerRigidbody;          

    SpriteRenderer playerSpriteRend;

    void Awake()
    {
        anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerSpriteRend = GetComponent<SpriteRenderer>();
    }


    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");

        Move(h);
       
        Animating(h);
    }

    void Move(float h)
    {
        movement.Set(h, 0f, 0f);

        movement = movement.normalized * speed * Time.deltaTime;

        playerRigidbody.MovePosition(transform.position + movement);
    }

    void Animating(float h)
    {
        bool walking = h != 0f;

        if (h >= 0.01)
        {
            playerSpriteRend.flipX = false;
        }
        if (h <= -0.01)
        {
            playerSpriteRend.flipX = true;
        }

        anim.SetBool("IsMoving", walking);
    }
}
