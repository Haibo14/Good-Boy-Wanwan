using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class LevelManagerTest : MonoBehaviour
{
    public GameObject DuoPrefab;

    public GameObject CheckPoint;

    public GameObject DeathMenu;

    public GameObject whoIsDeadText;

    //public TextMeshProUGUI whoIsDead;

    public bool wanwanIsDead;
    public bool grannyIsDead;
    bool lost;

    void Start()
    {
       
        
        wanwanIsDead = false;
        grannyIsDead = false;
        lost = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindWithTag("Duo");

        if (wanwanIsDead == true)
        {
            lost = true;
            TextMeshProUGUI whoIsDead = whoIsDeadText.GetComponent<TextMeshProUGUI>();

            whoIsDead.SetText("Wanwan is dead");
        }

        if (grannyIsDead == true)
        {


            lost = true;
            TextMeshProUGUI whoIsDead = whoIsDeadText.GetComponent<TextMeshProUGUI>();

            whoIsDead.SetText("Granny is dead");
        }


        if (lost == true)
        {
            DeathMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        
    }

    public void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        /*DeathMenu.SetActive(false);
        lost = false;
        GameObject player = GameObject.FindWithTag("Duo");
        Destroy(player);

        Instantiate(DuoPrefab, CheckPoint.transform.position, Quaternion.identity);
        wanwanIsDead = false;
        grannyIsDead = false;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;*/
    }

        
}

