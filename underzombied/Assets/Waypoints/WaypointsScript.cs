using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaypointsScript : MonoBehaviour
    {
    public GameOverScript gosc;

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
            SceneManager.LoadScene(2);
            }
        }

 
    }
