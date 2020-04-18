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
	        Destroy(CarPrefab_o, 30.0f);

	    	GameObject CarPrefab_o2 = Instantiate(CarPrefab2, Spawn2.position, gameObject.transform.rotation) as GameObject;
	        Destroy(CarPrefab_o2, 30.0f);

	        GameObject CarPrefab_o3 = Instantiate(CarPrefab3, Spawn3.position, Quaternion.identity) as GameObject;
	        Destroy(CarPrefab_o3, 30.0f);

	        GameObject CarPrefab_o4 = Instantiate(CarPrefab4, Spawn4.position, Quaternion.identity) as GameObject;
	        Destroy(CarPrefab_o4, 30.0f);


	    	Timer = Random.Range(1,3);
    	}    
    }
}
