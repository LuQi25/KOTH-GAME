using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisiblePJ : MonoBehaviour
{
    GameObject Elevador;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Elevador"))
        {
            Destroy(gameObject);
        }
    }
}
