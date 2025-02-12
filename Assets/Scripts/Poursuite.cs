using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poursuite : MonoBehaviour
{
    [SerializeReference] GameObject poissonCible;
    [SerializeField] private float vitesse;

    void Update()
    {
        transform.LookAt(poissonCible.transform, Vector3.up);
        transform.Translate(0, 0, vitesse * Time.deltaTime, Space.Self);
    }
}
