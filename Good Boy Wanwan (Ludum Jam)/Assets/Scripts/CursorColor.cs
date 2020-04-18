﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorColor : MonoBehaviour
{
	public Material[] Material;
	private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
    	rend = GetComponent<Renderer>();
    	rend.sharedMaterial = Material[0];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
    	if(other.gameObject.CompareTag("Destination1")){
    		rend.sharedMaterial = Material[1];

    		Debug.Log("changement couleur");
    	}
    }
}
