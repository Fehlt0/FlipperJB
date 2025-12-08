using System;
using System.Collections;
using UnityEngine;

public class BumperTank : MonoBehaviour
{
    [SerializeField] private GameObject wall;
    private int nbTouched;
    [SerializeField] private int maxTouched = 5;
    
    private void OnCollisionEnter(Collision other)
    {
        if (nbTouched >= maxTouched)
        {
            StartCoroutine(WallActivateDelay());
            nbTouched = 0;
        }
        else
        {
            nbTouched++;
        }
    }
    IEnumerator WallActivateDelay()
    {
        wall.SetActive(true);
        yield return new WaitForSeconds(5);
        wall.SetActive(false);
    }
}

