using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curseur : MonoBehaviour
{
	public Transform Destination1;
	public Transform Destination2;
	public Transform Target;

	public Material[] Material;
	private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {	rend = GetComponent<Renderer>();

        Target = Destination1;
        rend.sharedMaterial = Material[0];
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Target);
        transform.Rotate(0.0f, 290.0f, 0.0f, Space.World);

    }

    void OnTriggerEnter(Collider other){
    	if(other.gameObject.CompareTag("Destination1")){
    		Target = Destination2;
    		rend.sharedMaterial = Material[1];

    		Debug.Log("changement Target");
    	}

    	
    }
}
