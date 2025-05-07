using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Vector3 GameArea1 = new Vector3(-0.5f, 8, 0);
    public void NpcTalkYes()
    {
        GameManager.Instance.player.playerLastPos = GameManager.Instance.player.transform.position;
        GameManager.Instance.player.transform.position = GameArea1;
    }
}
