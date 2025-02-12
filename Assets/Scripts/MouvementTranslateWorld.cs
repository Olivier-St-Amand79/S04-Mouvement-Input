using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementTranslateWorld : MonoBehaviour
{
    [SerializeReference] float _vitesse_x = 0f;
    [SerializeReference] float _vitesse_z = 0f;
    [SerializeReference] float _vitesse_y = 0f;
    void Update()
    {
        transform.Translate(_vitesse_x * Time.deltaTime, _vitesse_y * Time.deltaTime, _vitesse_z * Time.deltaTime, Space.World);

        //Vector3 deplacement = new Vector3(1f, 0, 0);
        //transform.Translate(deplacement * Time.deltaTime, Space.World);
    }
}
