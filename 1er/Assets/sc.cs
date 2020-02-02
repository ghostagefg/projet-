using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    private const float V = 0.08f;
    public float tt = V;
    public float U;

    void Update()
    { 
        if (Input.GetKey(KeyCode.E))
        {
            tt = 0.2f;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Translate(-tt, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(tt, 0, 0);
        }

        else;
        {
            tt = V;
        }

    }
}