using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texto : MonoBehaviour
{
    private float velocidadeDeMovimento = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 100)
        {
            transform.position = transform.position + new Vector3(0, 3 *
                velocidadeDeMovimento * Time.deltaTime, 0);
        }
    }
}