using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecatEstadoJugador : MonoBehaviour
{
    Transform posInicio;
    // Start is called before the first frame update
    void Start()
    {
        posInicio = GameObject.Find("Area inicio").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float valY = transform.position.y;

        if (valY<-10.0f)
        {
            transform.position = posInicio.position;
        }
    }
}
