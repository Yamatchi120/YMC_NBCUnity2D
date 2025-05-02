using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected virtual void Move() { }

    protected virtual void Rotate() { }

    protected virtual void Jump(){ }
}
