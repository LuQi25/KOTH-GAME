using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassLvl3 : MonoBehaviour
{
    public GameObject lvl3;


    private void OnTriggerEnter2D(Collider2D collis)
    {
        if (collis.tag == "Player")
        {
            SceneManager.LoadScene(3);
            Time.timeScale = 1;
        }
            
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
