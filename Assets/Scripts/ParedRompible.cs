using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedRompible : MonoBehaviour
{
    public GameObject Muro;



    /*private void OnTriggerEnter2D(Collider2D collis)
    {
        if (Input.GetKey(KeyCode.Z))
        //if (collis.CompareTag("Bullet"))
        {
            Muro.SetActive(false);
        }
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (Input.GetKey(KeyCode.Z))
        if (collision.collider.tag=="Bullet")
        {
            Muro.SetActive(false);
        }
    }


    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
