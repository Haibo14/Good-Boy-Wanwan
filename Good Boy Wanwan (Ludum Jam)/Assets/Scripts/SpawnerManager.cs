using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
	public Vector3 spawnValues_Cow;
	public GameObject CowPrefab;
	public int Cow_Number;
    // Start is called before the first frame update
    void Start()
    {
    	for(int i = 0; i < Cow_Number; i ++){
	        Vector3 spawnPosition_Cow = new Vector3(Random.Range(-spawnValues_Cow.x, spawnValues_Cow.x), 1, Random.Range(-spawnValues_Cow.z, spawnValues_Cow.z));
	        GameObject Fish_Object = Instantiate(CowPrefab, spawnPosition_Cow + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
    	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
