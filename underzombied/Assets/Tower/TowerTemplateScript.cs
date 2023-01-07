using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTemplateScript : MonoBehaviour
{
    public GameObject tower;
    private Vector2 mouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(Mathf.Round(mouse.x + 0.5f) -0.5f, Mathf.Round(mouse.y + 0.5f) - 0.5f);

        if (Input.GetMouseButtonDown(0)){
            Instantiate(tower, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }
}
