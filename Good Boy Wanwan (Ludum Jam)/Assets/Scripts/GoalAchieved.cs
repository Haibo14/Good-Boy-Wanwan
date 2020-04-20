using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalAchieved : MonoBehaviour
{

    void Start()
    {
        
    }

  
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject manager = GameObject.FindWithTag("Manager");
            manager.GetComponent<NextScene>().levelIsDone = true;

            Debug.Log("Congrats");
        }
    }
}
