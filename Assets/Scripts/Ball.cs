using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float lifePoints;


    public void LoseBallLife(float power)
    {
        lifePoints -= power;
        Debug.Log(lifePoints);
    }

    void Update()
    {
        if (lifePoints <= 0)
        {
            Destroy(gameObject);
            GameManager.instance.SpawnBall();
        }
    }
    





}
