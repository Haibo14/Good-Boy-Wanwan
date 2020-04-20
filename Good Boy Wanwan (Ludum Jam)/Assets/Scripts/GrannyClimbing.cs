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
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, lookDown, out hit, distance))
        {
          
            Vector3 targetLocation = hit.point;

           

            if (targetLocation.y < player.transform.position.y -0.4f && hit.collider.gameObject.CompareTag("Ground"))
            {


                player.transform.Rotate(new Vector3(0.3f,0,0));
                Debug.Log("Ca monte");

            }

            Debug.DrawRay(transform.position, lookDown);
        }
    }
}
