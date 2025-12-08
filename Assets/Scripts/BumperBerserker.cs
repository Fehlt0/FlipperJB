using System;
using UnityEngine;
using System.Collections;

public class BumperBerserker : MonoBehaviour
{
    private int nbTouched = 0;
    [SerializeField] private int maxTouched = 1;
    [SerializeField] private GameObject parent;

    public float rotationSpeed;
    public float rotationSpeedBase = 1;
    public float rotationSpeedBerserk = 2;

    private void Start()
    {
        rotationSpeed = rotationSpeedBase;
    }

    private void Update()
    {
        transform.localEulerAngles =
            new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z + rotationSpeed );
    }

    private void OnCollisionEnter(Collision other)
    {
        if (nbTouched >= maxTouched)
        {
            rotationSpeed = rotationSpeedBerserk;
            nbTouched = 0;
        }
        else
        {
            rotationSpeed = rotationSpeedBase;
            nbTouched++;
        }
    }
}
