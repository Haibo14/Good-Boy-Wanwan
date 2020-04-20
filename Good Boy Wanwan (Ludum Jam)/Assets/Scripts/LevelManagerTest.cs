using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerTest : MonoBehaviour
{
    public GameObject DuoPrefab;

    public GameObject CheckPoint;

    public bool someoneIsDead;

    void Start()
    {
        someoneIsDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindWithTag("Duo");

        if (someoneIsDead == true)
        {
            Destroy(player.gameObject);
        }

        if (player == null)
        {
            Instantiate(DuoPrefab, CheckPoint.transform.position, Quaternion.identity);
            someoneIsDead = false;
        }

        
    }
}
