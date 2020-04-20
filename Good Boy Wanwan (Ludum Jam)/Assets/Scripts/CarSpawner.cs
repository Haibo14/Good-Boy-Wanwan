using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
	public Transform Spawn1;
	public Transform Spawn2;
	public Transform Spawn3;
	public Transform Spawn4;

	public float Speed;
	public GameObject CarPrefab;
	public GameObject CarPrefab2;
	public GameObject CarPrefab3;
	public GameObject CarPrefab4;

	private float Timer;
	public float TimerWave;
	public float TimerWave2;

	public bool Go;

    // Start is called before the first frame update
    void Start()
    {	
    	TimerWave = 4.0f;
    	TimerWave2 = 8.0f;
    	Timer = 3.0f;
    	Go = true;
    
        //GameObject Fish_Object = Instantiate(CarPrefab, position, gameObject.transform.rotation);    
    }

    // Update is called once per frame
    void Update()
    {	
    	TimerWave -= Time.deltaTime;
    	TimerWave2 -= Time.deltaTime;

    	if(TimerWave<0){
    		Go = false;
    		if(TimerWave2<0){
    			TimerWave = 4.0f;
    			TimerWave2 = 8.0f;

    			Go= true;
    		}
    	}


    	Timer -= Time.deltaTime;

    	if(Timer<0 && Go == true){
	    	GameObject CarPrefab_o = Instantiate(CarPrefab, Spawn1.position, gameObject.transform.rotation) as GameObject;
	        

	    	GameObject CarPrefab_o2 = Instantiate(CarPrefab2, Spawn2.position, gameObject.transform.rotation) as GameObject;
	        

	        GameObject CarPrefab_o3 = Instantiate(CarPrefab3, Spawn3.position, Quaternion.identity) as GameObject;
	        

	        GameObject CarPrefab_o4 = Instantiate(CarPrefab4, Spawn4.position, Quaternion.identity) as GameObject;
	        


	    	Timer = Random.Range(2,6);
    	}    
    }
}
