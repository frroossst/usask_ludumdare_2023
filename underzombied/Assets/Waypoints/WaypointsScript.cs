using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointsScript : MonoBehaviour
    {
    public Transform[] waypoints;
    int waypointIndex = 0;

    private float moveSpeed = 1f;

    void Start()
        {
        transform.position = waypoints[waypointIndex].transform.position;
        }

    void Update()
        {
        float step =  moveSpeed * Time.deltaTime;
        
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, step);

        if (transform.position == waypoints[waypointIndex].transform.position)
            {
            waypointIndex++;
            }
        
        if (waypointIndex == waypoints.Length)
            {
            waypointIndex = 0;
            }
        }

 
    }
