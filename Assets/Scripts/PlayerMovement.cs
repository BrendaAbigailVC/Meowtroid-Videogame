using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walk=2;
    public float jump=3;
    Rigidbody2D rb2d;
    public SpriteRenderer  spriteRenderer;
    public Animator animator;

    void Start()
    {
        rb2d= GetComponent<Rigidbody2D>();      
    }

    void FixedUpdate()
    {
        if(Input.GetKey("d")||Input.GetKey("right")){
            rb2d.velocity = new Vector2(walk, rb2d.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);

        } else if(Input.GetKey("a")||Input.GetKey("left")){
            rb2d.velocity = new Vector2(-walk, rb2d.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);

        }else{
            rb2d.velocity= new Vector2(0,rb2d.velocity.y);
            animator.SetBool("Run", false);
        }
        if(CheckGround.isGrounded==false){
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if(CheckGround.isGrounded==true){
            animator.SetBool("Jump", false);
        }

        if(Input.GetKey("space") && CheckGround.isGrounded){
            rb2d.velocity= new Vector2(rb2d.velocity.x,jump);
        } 
    }
}
