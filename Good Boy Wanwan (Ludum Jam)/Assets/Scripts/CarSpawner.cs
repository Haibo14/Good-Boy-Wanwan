using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
	public Transform Spawn1;
	public Transform Spawn2;
	public float Speed;
	public GameObject CarPrefab;
	public GameObject CarPrefab2;

	private float Timer;

    // Start is called before the first frame update
    void Start()
    {	Timer = 3.0f;
        //GameObject Fish_Object = Instantiate(CarPrefab, position, gameObject.transform.rotation);

        
    }

    // Update is called once per frame
    void Update()
    {	
    	Timer -= Time.deltaTime;
    	if(Timer<0){
	    	GameObject CarPrefab_o = Instantiate(CarPrefab, Spawn1.position, gameObject.transform.rotation) as GameObject;
	        Destroy(CarPrefab_o, 14.0f);

	    	GameObject CarPrefab_o2 = Instantiate(CarPrefab2, Spawn2.position, gameObject.transform.rotation) as GameObject;
	        Destroy(CarPrefab_o2, 14.0f);

	    	Timer = Random.Range(1,3);
    	}    
    }
}
