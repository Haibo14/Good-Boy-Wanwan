using UnityEngine;
using System.Collections;

public class LeashPoints : MonoBehaviour
{
    LineRenderer lr;
    public Transform[] Positions;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        lr.positionCount = Positions.Length;
        lr.SetPosition(0, Positions[0].position);
        lr.SetPosition(1, Positions[1].position);
        lr.SetPosition(2, Positions[2].position);
        lr.SetPosition(3, Positions[3].position);
        lr.SetPosition(4, Positions[4].position);
        lr.SetPosition(5, Positions[5].position);
        lr.SetPosition(6, Positions[6].position);

    }
}