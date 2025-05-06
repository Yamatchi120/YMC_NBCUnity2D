using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looper : MonoBehaviour
{
    public int arrayCount = 0;
    public Vector3 arrayLastPos = Vector3.zero;
    protected virtual void TrapIndex()
    {
        //TrapBase[] arrayEx = GameObject.FindObjectOfType<TrapBase>();
        TrapBase[] arrayEx = GameObject.FindObjectsOfType<TrapBase>();
        arrayLastPos = arrayEx[0].transform.position;
        arrayCount = arrayEx.Length;

        for (int i = 0; i < arrayCount; i++)
        {
            arrayLastPos = arrayEx[i].RandomPlace(arrayLastPos);
        }
    }
    protected virtual void TrapShuffle()
    {

    }
    protected virtual void TrapDamage()
    {

    }
}
