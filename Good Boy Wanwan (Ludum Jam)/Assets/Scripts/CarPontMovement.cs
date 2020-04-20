using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPontMovement : MonoBehaviour
{
    public float Speed;

    bool driving;
    // Start is called before the first frame update
    void Start()
    {
        driving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (driving == true)
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime, Space.World);

        }

        if (driving == false)
        {
            transform.Translate(new Vector3(0, 0, 0));
        }
    }

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.CompareTag("LeashAndWheelchair") || collider.gameObject.CompareTag("Player") || collider.gameObject.CompareTag("Car"))
        {

            float force = 5000;

            Vector3 dir = collider.contacts[0].point - transform.position;

            dir = -dir.normalized;

            GetComponent<Rigidbody>().AddForce(dir * force);

            driving = false;

        }
    }
}
