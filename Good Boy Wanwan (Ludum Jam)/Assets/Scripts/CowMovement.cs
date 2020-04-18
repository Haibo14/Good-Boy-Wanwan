using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowMovement : MonoBehaviour
{
	public float Speed;
	public float WonderTime;
    public float TurnSpeed;
    void Start()
    {
        Wonder();
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.Rotate (Vector3.up * -Time.deltaTime * TurnSpeed);
        if(WonderTime > 0){
    		transform.Translate(Vector3.forward * Speed);
    		WonderTime -= Time.deltaTime;
    	} else {
    		WonderTime = Random.Range(1.0f, 2.0f);
    		transform.Rotate (Vector3.up * Time.deltaTime * TurnSpeed);
    	}


    	if(Speed > 0.05f){
    		Speed = Speed - 0.005f;
    	}

    }

    void OnTriggerEnter(Collider other){
    	if(other.gameObject.CompareTag("Forbidden_cows")){
    		transform.eulerAngles = new Vector3 (0, 180, 0);
    	}
    }

    void OnCollisionEnter(Collision collision){
        Wonder();
    }

    void Wonder(){
        transform.eulerAngles = new Vector3 (0, Random.Range(0, 360), 0);
    }


}
