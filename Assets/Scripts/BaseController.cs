using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected Rigidbody2D rb;

    protected Vector2 moveDirection = Vector2.zero;
    public Vector2 MoveDirection { get { return moveDirection; } }
    protected virtual void FixedUpdate()
    {
        Move();
    }
    protected virtual void Move()
    {
        
    }

    protected virtual void Rotate() { }

    protected virtual void Jump(){ }
}
