using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasoIntro : MonoBehaviour
{
    //public string CargarNivel;
    public float SegundosEspera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SegundosEspera -= Time.deltaTime;
        if (SegundosEspera <= 0)
        {
         SceneManager.LoadScene(1);
        }
    }
}
