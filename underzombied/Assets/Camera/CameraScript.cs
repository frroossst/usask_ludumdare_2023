using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Rigidbody2D bod;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && transform.position.x < 18.5){
            bod.velocity = new Vector2(8, 0);
        }
        else if (Input.GetKey(KeyCode.A) && transform.position.x > -1.5){
            bod.velocity = new Vector2(-8, 0);
        }
        else{
            bod.velocity = new Vector2(0, 0);
        }
    }
}
