using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    bool levelIsDone;

    void Start()
    {
        levelIsDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (levelIsDone == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void goNext()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
