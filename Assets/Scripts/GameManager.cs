using System;
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
    [SerializeField] public static int ennemisVivants = 0;
    private int i = 0;
    
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
        ennemisVivants -= 1;

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
        if (i == listeEnnemis.Count && ennemisVivants == 0)
        {
            Win();
        }
        else if (i < listeEnnemis.Count)
        {
            ennemisVivants += 1;
            Debug.Log(ennemisVivants);
            Instantiate(listeEnnemis[i], spawnPoint.position, Quaternion.identity, transform);
            i++;
        }
        
    }

   
    
    
    
}