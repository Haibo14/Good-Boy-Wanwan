using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrannyClimbing : MonoBehaviour
{
    public GameObject player;

    public float distance = 300f;
    void FixedUpdate()
    {
        Vector3 lookDown = new Vector3(0, -10, 0) + player.transform.position;
        
        transform.LookAt(lookDown);
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, Vector3.down, out hit, distance))
        {
          
            Vector3 targetLocation = hit.point;

            

            if (targetLocation.y > player.transform.position.y -0.5f  && hit.collider.gameObject.CompareTag("Ground"))
            {


                player.transform.Rotate(new Vector3(-15f,0,0));
                Debug.Log("Ca monte");

            }

            Debug.DrawRay(transform.position, Vector3.down);
        }
    }
}
