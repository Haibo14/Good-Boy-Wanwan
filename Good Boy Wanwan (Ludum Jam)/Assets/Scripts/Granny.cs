using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granny : MonoBehaviour
{


	public GameObject granny;

	public AudioSource[] OySounds;

	public AudioSource impact;

    void Start()
    {
		StartCoroutine(Scream());
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
			float force2 = 1000;

			Vector3 dir = collider.contacts[0].point - transform.position;

			dir = -dir.normalized;

			GetComponent<Rigidbody>().AddForce(dir * force);

			granny.transform.parent = null;
			//granny.AddComponent<BoxCollider>();
			granny.AddComponent<Rigidbody>();

			granny.GetComponent<Rigidbody>().AddForce(dir * force2);

			GameObject manager = GameObject.FindWithTag("Manager");
			manager.GetComponent<LevelManagerTest>().grannyIsDead = true;

			if (!impact.isPlaying)
			{
				impact.Play(0);
			}



		}
	}

	IEnumerator Scream()
	{

		int index = Random.Range(0, OySounds.Length);
		AudioSource playingSound = OySounds[index];

		playingSound.Play(0);

		Debug.Log("Playing");

		yield return new WaitForSeconds(Random.Range(7.0f, 15.0f));

		StartCoroutine(Scream());
	}
}
