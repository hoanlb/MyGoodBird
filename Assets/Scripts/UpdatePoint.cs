using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        GameCommon.Instance.AddPoint(1);
        Destroy(gameObject);
    }
}
