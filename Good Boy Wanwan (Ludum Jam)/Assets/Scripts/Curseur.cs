using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curseur : MonoBehaviour
{
	public Transform Destination1;
	public Transform Destination2;

	public Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        Target = Destination1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Target);
        transform.Rotate(30.0f, 180.0f, 0.0f, Space.World);

    }

    void OnColliderEnter(Collider other){
    	if(other.gameObject.CompareTag("Destination1")){
    		Target = Destination2;
    		Debug.Log("changement Target");
    	}

    	
    }
}
