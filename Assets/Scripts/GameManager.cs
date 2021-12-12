using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    //bool gameOver = false;
    [SerializeField] GameObject player;
    
    //[SerializeField] GameObject gameOverUI;



    
    void Start()
    {
       
        //gameOverUI.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

       

    }


    public void StartGame()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void Juego2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void Juego3()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }

    public void salir()
    {
        Application.Quit();
    }


}
