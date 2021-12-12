using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMPausa : MonoBehaviour
{
    bool gamePaused = false;
    [SerializeField] GameObject pauseUI;

    void Start()
    {
        pauseUI.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }
    public void PauseGame()
    {
        gamePaused = gamePaused ? false : true;

        //player.gamePaused = gamePaused;

        pauseUI.SetActive(gamePaused);

        Time.timeScale = gamePaused ? 0 : 1;
    }

    public void continueGame()
    {
        pauseUI.SetActive(false);
        Time.timeScale = gamePaused ? 1 : 1;
    }
    
}
