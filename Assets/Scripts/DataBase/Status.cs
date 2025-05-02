using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    [SerializeField] private int baseHp = 100;
    [SerializeField] private float baseSpeed = 1f;
    [SerializeField] private float baseJumpForce = 1f;

    public int BaseHp
    {
        // 최대체력 100
        get {  return baseHp; }
        set { baseHp = Mathf.Clamp(value, 0, 100); }
    }
    public float BaseSpeed { get; set; }
    public float BaseJumpForce { get; set; }
}
