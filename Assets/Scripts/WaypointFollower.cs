using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currerntWaypointIndex = 0;
    [SerializeField] private float speed = 2f;



   private void Update()
    {
        if (Vector2.Distance(waypoints[currerntWaypointIndex].transform.position, transform.position)<.1f)
        {
            currerntWaypointIndex++;
            if (currerntWaypointIndex >= waypoints.Length)
            {
                currerntWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currerntWaypointIndex].transform.position, Time.deltaTime * speed);
        
    }
}
