using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    void NpcTalkYes()
    {
        GameManager.Instance.player.playerLastPos = Vector3.zero;
    }
}
