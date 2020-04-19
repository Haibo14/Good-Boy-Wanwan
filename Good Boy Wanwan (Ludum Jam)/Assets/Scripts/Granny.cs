using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granny : MonoBehaviour
{
	public TextMesh DeathText;
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other){
		if(other.gameObject.CompareTag("Car")){
			DeathText.text = "Granny is dead";
			Destroy(DeathText, 5.0f);
			//Destroy(this.gameObject, 5.0f);
		}
	}
}
