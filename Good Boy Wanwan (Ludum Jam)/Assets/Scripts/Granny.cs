using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granny : MonoBehaviour
{
	public TextMesh DeathText;

	public GameObject granny;
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnCollisionEnter(Collision collider)
	{


		if (collider.gameObject.CompareTag("Car"))
		{
			Debug.Log("Hit");

		

			float force = 2000;
			float force2 = 500;

			Vector3 dir = collider.contacts[0].point - transform.position;

			dir = -dir.normalized;

			GetComponent<Rigidbody>().AddForce(dir * force);

			granny.transform.parent = null;
			granny.AddComponent<BoxCollider>();
			granny.AddComponent<Rigidbody>();

			granny.GetComponent<Rigidbody>().AddForce(dir * force2);



		}
	}
}
