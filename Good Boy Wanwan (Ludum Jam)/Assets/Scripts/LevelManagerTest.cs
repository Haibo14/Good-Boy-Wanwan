using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerTest : MonoBehaviour
{
    public GameObject DuoPrefab;

    public GameObject CheckPoint;

    public GameObject DeathMenu;

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

        if (wanwanIsDead == true || grannyIsDead == true)
        {
            lost = true;
        }

        if (player == null)
        {
            Instantiate(DuoPrefab, CheckPoint.transform.position, Quaternion.identity);
            wanwanIsDead = false;
            grannyIsDead = false;
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
        DeathMenu.SetActive(false);
        lost = false;
        GameObject player = GameObject.FindWithTag("Duo");
        Destroy(player);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

        
}

