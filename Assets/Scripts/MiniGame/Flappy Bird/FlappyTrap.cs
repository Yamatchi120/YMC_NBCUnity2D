using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBase : MonoBehaviour
{
    public float highPosY = 1f;
    public float lowPosY = -1f;

    public float holeSizeMin = 1f;
    public float holeSizeMax = 3f;

    public float widthPadding = 4f;

    public Transform topObj;
    public Transform btmObj;
    public Vector3 RandomPlace(Vector3 lastPos)
    {
        float holeSize = Random.Range(holeSizeMin, holeSizeMax);
        float halfHoleSize = holeSize / 2;

        topObj.localPosition = new Vector3(0, halfHoleSize);
        btmObj.localPosition = new Vector3(0, -halfHoleSize);

        Vector3 placePos = lastPos + new Vector3(widthPadding, 0);
        placePos.y = Random.Range(lowPosY, highPosY);

        transform.position = placePos;

        return placePos;
    }
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    Player player = collision.GetComponent<Player>();
    //    if (player != null) gameManager.AddScore(1);
    //}
}
