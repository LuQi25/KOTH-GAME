using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasoInicio : MonoBehaviour
{
    public float SegundosEspera;

    void Start()
    {
        
    }

    
    void Update()
    {
        SegundosEspera -= Time.deltaTime;
        if (SegundosEspera <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
