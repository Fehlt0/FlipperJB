
using UnityEngine;

public class BumperNormal : MonoBehaviour
{
    public float strength = 1;
    [SerializeField] private int score = 10;
    [SerializeField] private GameObject menu;
    [SerializeField] private bool menuOpen;
    [SerializeField] private int power;

    void OnCollisionEnter(Collision other)
    {
        Vector3 ballDirection = other.relativeVelocity;
        Vector3 normal = -other.contacts[0].normal;
        Vector3 direction = Vector3.Reflect(ballDirection, normal);

        Debug.DrawRay(other.contacts[0].point, direction, Color.red, 10);
        Debug.DrawRay(other.contacts[0].point, normal, Color.blue, 10);
        
        other.gameObject.GetComponent<Ball>().LoseBallLife(power);


        other.rigidbody.AddForce(direction * strength);
        ScoreManager.instance.AddScore(score);
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
}