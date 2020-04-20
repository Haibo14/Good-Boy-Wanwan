using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject granny;

    bool alive;

    void Start()
    {
        alive = true;
    }

    void FixedUpdate()
    {
        Vector3 u = transform.TransformDirection(Vector3.up);
        Vector3 l = transform.TransformDirection(Vector3.left);
        Vector3 r = transform.TransformDirection(Vector3.right);
        Vector3 f = transform.TransformDirection(Vector3.forward);

        RaycastHit hit;

        if (Physics.Raycast(transform.position, u, out hit, 0.3f))
        {
            if (hit.collider.gameObject.CompareTag("Ground"))
            {
                Debug.Log("Grounded");
                alive = false;
            }
        }

        if (Physics.Raycast(transform.position, l, out hit, 0.25f))
        {
            if (hit.collider.gameObject.CompareTag("Ground"))
            {
                Debug.Log("Grounded");
                alive = false;
            }
        }

        if (Physics.Raycast(transform.position, r, out hit, 0.25f))
        {
            if (hit.collider.gameObject.CompareTag("Ground"))
            {
                Debug.Log("Grounded");
                alive = false;
            }
        }

        if (Physics.Raycast(transform.position, f, out hit, 0.25f))
        {
            if (hit.collider.gameObject.CompareTag("Ground"))
            {
                Debug.Log("Grounded");
                alive = false;
            }
        }

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * 0.3f, Color.yellow);

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * 0.25f, Color.yellow);

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * 0.25f, Color.yellow);

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 0.25f, Color.yellow);

        if(alive == false)
        {
            granny.transform.parent = null;
            granny.AddComponent<Rigidbody>();
            GameObject manager = GameObject.FindWithTag("Manager");
            manager.GetComponent<LevelManagerTest>().grannyIsDead = true;
            alive = true;
        }
    }

}
