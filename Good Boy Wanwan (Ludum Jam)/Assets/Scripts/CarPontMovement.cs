﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPontMovement : MonoBehaviour
{
	public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	transform.Translate(new Vector3(1, 0, 0) * Speed);   
    }
}
