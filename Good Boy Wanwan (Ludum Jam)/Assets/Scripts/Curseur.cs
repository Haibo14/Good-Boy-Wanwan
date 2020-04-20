using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curseur : MonoBehaviour
{
	public Transform Destination1;
	public Transform Destination2;
	public Transform Destination3;
	public Transform Destination4;
	public Transform Target;

    bool _Destination1;
    bool _Destination2;
    bool _Destination3;
    bool _Destination4;
    


    // Start is called before the first frame update
    void Start()
    {

       

        _Destination1 = true;
        _Destination2 = false;
        _Destination3 = false;
        _Destination4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Target);
        transform.Rotate(0.0f, 180.0f, 0.0f, Space.World);

        if (_Destination1)
        {
            Target = Destination1;
        }

        if (_Destination2)
        {
            Target = Destination2;
            Debug.Log("changement Target1");
        }

        if (_Destination3)
        {
            Target = Destination3;
            Debug.Log("changement Target2");
        }

        if (_Destination4)
        {
            Target = Destination4;
            Debug.Log("changement Target3");
        }

    }

    void OnTriggerEnter(Collider other){
    	if(other.gameObject.CompareTag("Destination1")){
            _Destination2 = true;
        }

    	if(other.gameObject.CompareTag("Destination2")){
            _Destination3 = true;
        }

    	if(other.gameObject.CompareTag("Destination3")){
            _Destination4 = true;
        }

    	if(other.gameObject.CompareTag("Destination4")){
       		Debug.Log("You win");
    	}

    	
    }
}
