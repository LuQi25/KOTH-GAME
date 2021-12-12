using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class passdohpunto5 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collis)
    {
        if (collis.tag == "Player")
        {
            SceneManager.LoadScene(6);
            Time.timeScale = 1;
        }
            
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
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
