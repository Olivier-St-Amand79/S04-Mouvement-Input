using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementCourse : MonoBehaviour
{
    private float _x = 0f;
    // Start is called before the first frame update
    void Start()
    {
        _x = Random.Range(0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_x * Time.deltaTime, 0f, 0f, Space.World);

        if (transform.position.x > 5f)
        {
            Debug.Log(gameObject.name);
        }
    }
}
