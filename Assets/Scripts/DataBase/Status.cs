using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    [SerializeField] private int baseHp = 100;
    [SerializeField] private float baseSpeed = 5.0f;
    [SerializeField] private float baseJumpForce = 3.0f;

    public int BaseHp
    {
        // 최대체력 100
        get {  return baseHp; }
        set { baseHp = Mathf.Clamp(value, 0, 100); }
    }
    public float BaseSpeed
    {
        get { return baseSpeed; }
        set { baseSpeed = Mathf.Clamp(value, 0f, 10f); }
    }
    public float BaseJumpForce { get; set; }
}
