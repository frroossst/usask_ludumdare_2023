using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointsScript : MonoBehaviour
    {
    public Transform[] waypoints;

    int waypointIndex = 0;

    public float moveSpeed = 0.001f;

    void Start()
        {
        transform.position = waypoints[waypointIndex].transform.position;
        }

    void Update()
        {

        float step = moveSpeed * Time.deltaTime;
        step = 0;
        
        transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, step);

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