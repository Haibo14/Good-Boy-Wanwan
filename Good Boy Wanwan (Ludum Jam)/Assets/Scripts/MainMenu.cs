using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {

        //Charger la scène de jeu
        SceneManager.LoadScene("FirstScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
