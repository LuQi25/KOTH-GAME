using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertasBoton : MonoBehaviour
{

    public GameObject Puerta;
    //public GameObject Boton;
    //public GameObject PreBoton;
    Animator Panimator;

    

    void Start()
    {
       Panimator = GetComponent<Animator>();
    }
    

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //if (Input.GetKey(KeyCode.Z))
            //{
            Panimator.SetBool("IsPalanca", true);
            Puerta.SetActive(false);
            //Boton.SetActive(false);
            //PreBoton.SetActive(true);
            //}

        }


    }

}
