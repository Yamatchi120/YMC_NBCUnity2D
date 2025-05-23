using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    // 인스턴스 보호
    public PlayerController player { get; private set; }
    private void Awake()
    {
        if(Instance == null)
            Instance = this;

        player = FindObjectOfType<PlayerController>();
        player.Init(this);
    }
}
