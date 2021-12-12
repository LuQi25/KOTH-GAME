using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevador : MonoBehaviour
{
    Animator Ann;
    public float SecEsp;
    private bool Ischange = false;

    void Start()
    {
        
        Ann = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Ischange == true )
        {
            SecEsp -= Time.deltaTime;
            if (SecEsp <= 0)
            {
                SceneManager.LoadScene(5);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collis)
    {
        
        if (collis.tag == "Player" )
        {
            Ischange = true;
            Ann.SetBool("IsClosing", true);
        }

    }
}
