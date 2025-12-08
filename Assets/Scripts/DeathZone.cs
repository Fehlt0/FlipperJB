using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("false"))
        {
            Destroy(other.gameObject);
            GameManager.instance.LoseBall(false);
            Debug.Log("Une fausse balle est tombée");
        }
        else
        {
            Destroy(other.gameObject);
            GameManager.instance.LoseBall(true);
            Debug.Log("Une vraie balle est tombée");
        }
        
    }
}
