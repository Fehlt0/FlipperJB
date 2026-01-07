using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private int life = 3;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private List<GameObject> listeEnnemis;
    [SerializeField] private GameObject wall;
    private int i = 0;
    
    private int nbTankTouched;
    [SerializeField] private int maxTankTouched = 5;
    
    
    
    private void Awake()
    {
        instance = this;
    }
    


    private void Start()
    {
        SpawnBall();
    }

    
    public void LoseBall(bool type)
    {
        //Debug.Log("Lose Ball");

        life--;

        if (life < 1)
        {
            Debug.Log("Game Over");
        }
        else if (type == true)
        {
            SpawnBall();
            
        }
        
    }



    void Win()
    {
        Debug.Log("win");
    }

    
    public void SpawnBall()
    {
        if (i == listeEnnemis.Count)
        {
            Win();
        }
        else if (i < listeEnnemis.Count)
        {
            Instantiate(listeEnnemis[i], spawnPoint.position, Quaternion.identity, transform);
            i++;
        }
        
    }

    public void WallAppartition()
    {
        if (nbTankTouched >= maxTankTouched)
        {
            StartCoroutine(WallActivateDelay());
            nbTankTouched = 0;
        }
        else
        {
            nbTankTouched++;
        }
    }
    
    public IEnumerator WallActivateDelay()
    {
        wall.SetActive(true);
        yield return new WaitForSeconds(7);
        wall.SetActive(false);
    }

   
    
    
    
}