using System;
using UnityEditor.UI;
using UnityEngine;


public class Bumper : MonoBehaviour
{
    [SerializeField] float strength = 10f;
    [SerializeField] private int score = 10;
    [SerializeField] private int power;
    
    [SerializeField] private GameObject menu;
    [SerializeField] private bool menuOpen;
    [SerializeField] GameObject bumperChevalier;
    [SerializeField] GameObject bumperAssassin;
    [SerializeField] GameObject bumperPretre;
    [SerializeField] GameObject bumperTank;
    [SerializeField] GameObject bumperBerserk;
    public bool isChanged = false;
    
    
    void OnCollisionEnter(Collision other)
    {
        //Debug.Log(transform.position);
        Vector3 a = transform.position;
        Vector3 b = other.transform.position;
        Vector3 direction;
        direction = b - a;
        direction = direction.normalized;
        
        other.rigidbody.AddForce(direction * strength);
        
        ScoreManager.instance.AddScore(score);
        other.gameObject.GetComponent<Ball>().LoseBallLife(power);
        
        
        
        
    }
    void OnMouseDown()
    {
        OpenCloseMenu(); 
    }

    public void OpenCloseMenu()
    {
        menuOpen = !menuOpen;
        menu.SetActive(menuOpen);

        if (menuOpen)
        {
            Time.timeScale = 0;
        }
        else
        { 
            Time.timeScale = 1;
        }
    }

    public void SpawnBumperAssassin()
    {
        Vector3 tempPosition = transform.parent.position;
        Destroy(gameObject);
        Instantiate(bumperAssassin, tempPosition, Quaternion.identity);
        menu.SetActive(!menuOpen);
        Time.timeScale = 1;
        isChanged = true;

    }
    public void SpawnBumperChevalier()
    {
        Vector3 tempPosition = transform.parent.position;
        Destroy(gameObject);
        Instantiate(bumperChevalier, tempPosition, Quaternion.identity);
        menu.SetActive(!menuOpen);
        Time.timeScale = 1;
        isChanged = true;
    }
    
    public void SpawnBumperPretre()
    {
        Vector3 tempPosition = transform.parent.position;
        Destroy(gameObject);
        Instantiate(bumperPretre, tempPosition, Quaternion.identity);
        menu.SetActive(!menuOpen);
        Time.timeScale = 1;
        isChanged = true;
    }
    
    public void SpawnBumperTank()
    {
        Vector3 tempPosition = transform.parent.position;
        Destroy(gameObject);
        Instantiate(bumperTank, tempPosition, Quaternion.identity);
        menu.SetActive(!menuOpen);
        Time.timeScale = 1;
        isChanged = true;
    }
    
    public void SpawnBumperBerserk()
    {
        Vector3 tempPosition = transform.parent.position;
        Destroy(gameObject);
        Instantiate(bumperBerserk, tempPosition, Quaternion.identity);
        menu.SetActive(!menuOpen);
        Time.timeScale = 1;
        isChanged = true;
    }
}