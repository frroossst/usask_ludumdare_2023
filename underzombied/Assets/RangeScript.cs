using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeScript : MonoBehaviour
{
    public Vector2 mouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(Mathf.Round(mouse.x + 0.5f) -0.5f, Mathf.Round(mouse.y + 0.5f) - 0.5f, -0.6f);
        if (Input.GetMouseButtonDown(1) == true){
            Destroy(gameObject);
        }
    }
    public void setSize(float range){
        transform.localScale = new Vector3(range, range, 0);
    }
}
