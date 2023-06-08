using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    //Player
    public Rigidbody2D playerrb;
    public float movementSpeed = 5f;
    private Vector2 moveDirection;

    // Update is called once per frame
    private void FixedUpdate()
    {
        move(); 
    }

    private void Update()
    {
        processInput();
    }

    void processInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        
        moveDirection = new Vector2(moveX, moveY);
    }

    void move()
    {
        playerrb.velocity = new Vector2(moveDirection.x * movementSpeed, moveDirection.y * movementSpeed);

    }
}
