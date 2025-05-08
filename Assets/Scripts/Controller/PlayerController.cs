using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class PlayerController : BaseController
{
    private GameManager gameManager;

    Vector3 point;
    public Vector3 playerLastPos = Vector3.zero;
    public Renderer renderer;

    public void Start()
    {
        point = Camera.main.ScreenToWorldPoint(new
                Vector3(Input.mousePosition.x,
                Input.mousePosition.y,
                -Camera.main.transform.position.z));
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(point.ToString());
        }
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
    protected override void Rotate()
    {
        if(point.x < 0)
        {
            
        }
    }
    public void PlayerSavePos()
    {
        playerLastPos = transform.position;

        // 테스트용 player 위치 저장
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
