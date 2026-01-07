using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Necro : MonoBehaviour
{
    [SerializeField] private List<GameObject> spawnList;
    [SerializeField] private GameObject skeleton;
    [SerializeField] private float spawnTime;
    void Awake()
    {
        
        StartCoroutine(WaitForSkeletonSpawn());
        
    }

    private IEnumerator WaitForSkeletonSpawn()
    {
        
        yield return new WaitForSeconds(spawnTime);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(skeleton, spawnList[i].transform.position, Quaternion.identity, null);
            
        }
        StartCoroutine(WaitForSkeletonSpawn());
        


    }
}
