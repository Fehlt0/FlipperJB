using System;
using System.Collections;
using UnityEngine;

public class BumperTank : MonoBehaviour
{
    
    
    
    private void OnCollisionEnter(Collision other)
    {
        GameManager.instance.WallAppartition();
    }
    
}

