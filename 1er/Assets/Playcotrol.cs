using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playcotrol : MonoBehaviour
{
    private float mid;

    private Rigidbody2D rb;

    public float moovspeed = 10.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Chekimput()
    {
        mid = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        APM();
    }

    private void APM()
    {
        rb.velocity = new Vector2();


    }

}
