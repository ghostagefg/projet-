using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRIG : MonoBehaviour
{
    public GameObject player;
    Vector2 rspawn = new Vector2(-60, 50);
    private void OnTriggerEnter2D(Collider2D objet)
    {
        if (objet.name == "piere qui gere") ;
        print("ok");
        player.transform.position = rspawn;
    }
    void Update()
    {
        
    }

}
