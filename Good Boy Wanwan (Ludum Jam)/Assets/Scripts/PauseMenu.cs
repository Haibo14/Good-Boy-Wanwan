using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUi;
    public GameObject ControlsMenuUi;

    public GameObject MainCam;

   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPaused)
            {
                Resume();
            }else
            {
                Pause();
            }

        }
    }

    public void Resume()
    {
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;


    }
    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

 
    }

    public void LoadingControls()
    {
        PauseMenuUi.SetActive(false);
        ControlsMenuUi.SetActive(true);
    }

    public void LoadingMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Back()
    {
        ControlsMenuUi.SetActive(false);
        PauseMenuUi.SetActive(true);
    }
}

