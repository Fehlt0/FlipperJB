using System;
using System.Collections;
using UnityEngine;
public class ArrowSpawn : MonoBehaviour
{
    [SerializeField] float timeDelay = 15f;
    [SerializeField] float speed = 15f;
    [SerializeField] Vector3 direction;

    [SerializeField] private GameObject arrow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, timeDelay);
    }
    
    // Update is called once per frame
    IEnumerator WallActivateDelay()
    {
        Instantiate(arrow, gameObject.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
    }
}
