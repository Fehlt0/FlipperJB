using System;
using UnityEngine;
using System.Collections;


public class BumperBerserker : MonoBehaviour
{
    private int nbTouched = 0;
    [SerializeField] private int maxTouched = 0;
    [SerializeField] public GameObject parent;

    [SerializeField] private float berserkTime = 7;
    
    public AnimationClip animationBase;
    public AnimationClip animationBerserk;

    private void Start()
    {
        gameObject.GetComponentInParent<Animation>().clip = animationBase;
    }

    

    private void OnCollisionEnter(Collision other)
    {
        if (nbTouched >= maxTouched)
        {
            gameObject.GetComponentInParent<Animation>().clip = animationBerserk;
            StartCoroutine(BerserkCooldown());
            gameObject.GetComponentInParent<Animation>().clip = animationBase;
            nbTouched = 0;
        }
        else
        {
            gameObject.GetComponentInParent<Animation>().clip = animationBase;
            nbTouched++;
        }
    }

    private IEnumerator BerserkCooldown()
    {
        yield return new WaitForSeconds(berserkTime);
    }
}
