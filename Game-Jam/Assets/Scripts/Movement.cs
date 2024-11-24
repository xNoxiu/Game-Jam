using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // speed

    public bool nowAnim = false;
    private Rigidbody2D rb;
    public Animator animator;
    private Vector2 movement;

    private int newX;
    private int newY;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        //no move when dialogue now doing
        if (nowAnim)
        {
            movement = Vector2.zero;
            return;
        }
        //move a w s d
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement = movement.normalized;

        if( movement.x > 0.5 && movement.x < 1){
            newX = 2;
        }
        if(movement.x < -0.5 && movement.x > -1){
            newX = -2;
        }
        if( movement.x == 1){
            newX = 1;
        }
        if(movement.x == -1){
            newX = -1;
        }
        if( movement.x == 0){
            newX = 0;
        }
        if( movement.y > 0.5 && movement.y < 1){
            newY = 2;
        }
        if(movement.y < -0.5 && movement.y > -1){
            newY = -2;
        }
        if( movement.y == 1){
            newY = 1;
        }
        if(movement.y == -1){
            newY = -1;
        }
        if(movement.y == 0){
            newY = 0;
        }
        
        /*Debug.Log("x");
        Debug.Log(newX);
        Debug.Log("y");
        Debug.Log(newY);*/

        animator.SetInteger("MoveX", newX);
        animator.SetInteger("MoveY", newY);
        animator.SetBool("IsMoving", movement.sqrMagnitude > 0);


        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}