using System;
using UnityEditor.UI;
using UnityEngine;


public class Bumper : MonoBehaviour
{
    [SerializeField] float strength = 10f;
    [SerializeField] private int score = 10;
    [SerializeField] private Animation anim;
    [SerializeField] GameObject bumperSpawn;
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
        

        if (anim == null)
        {
            return;
        }
        anim.Play();
        
        
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
        (gameObject.transform.parent.position, bumperAssassin.transform.parent.position) = (bumperAssassin.transform.parent.position, gameObject.transform.parent.position);
        menu.SetActive(!menuOpen);
        Time.timeScale = 1;
        isChanged = true;

    }
    public void SpawnBumperChevalier()
    {
        (gameObject.transform.parent.position, bumperChevalier.transform.parent.position) = (bumperChevalier.transform.parent.position, gameObject.transform.parent.position);
        menu.SetActive(!menuOpen);
        Time.timeScale = 1;
        isChanged = true;
    }
    
    public void SpawnBumperPretre()
    {
        (gameObject.transform.parent.position, bumperPretre.transform.parent.position) = (bumperPretre.transform.parent.position, gameObject.transform.parent.position);
        menu.SetActive(!menuOpen);
        Time.timeScale = 1;
        isChanged = true;
    }
    
    public void SpawnBumperTank()
    {
        (gameObject.transform.parent.position, bumperTank.transform.parent.position) = (bumperTank.transform.parent.position, gameObject.transform.parent.position);
        menu.SetActive(!menuOpen);
        Time.timeScale = 1;
        isChanged = true;
    }
    
    public void SpawnBumperBerserk()
    {
        (gameObject.transform.parent.position, bumperBerserk.transform.parent.position) = (bumperBerserk.transform.parent.position, gameObject.transform.parent.position);
        menu.SetActive(!menuOpen);
        Time.timeScale = 1;
        isChanged = true;
    }
}