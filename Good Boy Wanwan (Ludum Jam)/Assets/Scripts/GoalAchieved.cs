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

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Congrats");

            GameObject manager = GameObject.FindWithTag("Manager");
            manager.GetComponent<NextScene>().levelIsDone = true;

           
        }
    }
}
