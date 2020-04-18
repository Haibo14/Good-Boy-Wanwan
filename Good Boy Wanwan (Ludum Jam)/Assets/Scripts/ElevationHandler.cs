using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevationHandler : MonoBehaviour
{
    /*
     * The wanted length for the Raycast.
     */
    public GameObject player;

    public float distance = 100f;
    void FixedUpdate()
    {
        /*
         * Create the hit object.
         */
        RaycastHit hit;
        /*-
         * Cast a Raycast.
         * If it hits something:
         */
        if (Physics.Raycast(transform.position, Vector3.down, out hit, distance))
        {
            /*
             * Set the target location to the location of the hit.
             */
            Vector3 targetLocation = hit.point;

            if (targetLocation.y < player.transform.position.y - 0.5f)
            {
                /*
                 * Modify the target location so that the object is being perfectly aligned with the ground (if it's flat).
                 */
                targetLocation += new Vector3(transform.parent.position.x, transform.localScale.y / 2, transform.parent.position.z);
                /*
                 * Move the object to the target location.
                 */


                //Vector3 checkerPos = new Vector3(transform.parent.position.x, targetLocation.y, transform.parent.position.z);

                transform.parent.position = targetLocation;

            }

            Debug.DrawRay(transform.position, Vector3.down);
        }
    }
}
