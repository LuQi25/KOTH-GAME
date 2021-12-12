using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassLvL2 : MonoBehaviour
{
    // para hacer una intro
    public string CargarNivel;
    public float SegundosEspera;

    private void OnTriggerEnter2D(Collider2D collis)
    {
        if (collis.tag == "Player")
        {
            SceneManager.LoadScene(2);
            Time.timeScale = 1;
        }
            
    }

    void Start()
    {
        
    }

  
    void Update()
    {
        // para hacer una intro
        //SegundosEspera -= Time.deltaTime;
        //if (SegundosEspera <= 0)
        //{
            //SceneManager.LoadScene(CargarNivel);
        //}

    }
}
