using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected Rigidbody2D rb;
    protected Status status;
    protected Animator anim;

    protected Vector2 moveDirection = Vector2.zero;
    public Vector2 MoveDirection { get { return moveDirection; } }
    
    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        status = GetComponent<Status>();
        anim = GetComponentInChildren<Animator>();
    }
    
    protected virtual void FixedUpdate()
    {
        Move();
    }
    protected virtual void Move()
    {
        
    }


    protected virtual void Rotate() { }
}
