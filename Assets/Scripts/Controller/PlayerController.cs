using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class PlayerController : BaseController
{
    private GameManager gameManager;

    public Vector3 playerLastPos = Vector3.zero;

    public void Update()
    {
        PlayerSavePos();
    }
    
    public void Init(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }
    protected override void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY);

        rb.velocity = moveDirection * status.BaseSpeed;

        anim.SetBool("isRun", moveDirection != Vector2.zero);
    }
    public void PlayerSavePos()
    {
        playerLastPos = transform.position;

        
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    Debug.Log("Pressed E");
        //    playerLastPos = transform.position;
        //    Debug.Log($"playerPos {playerLastPos}");
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    Debug.Log("Pressed R");

        //    transform.position = playerLastPos;
        //}
    }
}
