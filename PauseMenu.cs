//Pause menu script - When The key escape is entered pauses the game, and shows a list of buttons which are interactable to show controls, quit the game, and resume
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused) 
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }   
    }

   public void Resume()
    {
        
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false; 
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Pause()
    {
    
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Controls()
    {
        Debug.Log("Loading Menu");

    }


    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}
