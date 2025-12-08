using System;
using UnityEngine;

public class ZonePretre : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<Ball>().LoseBallLife(0.5f);
    }
}
