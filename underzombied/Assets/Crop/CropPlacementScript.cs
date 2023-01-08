using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropPlacementScript : MonoBehaviour
{
    public GameObject crop;

    // public BoxCollider2D bod;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    transform.position = new Vector2(Mathf.Round(mouse.x + 0.5f) -0.5f, Mathf.Round(mouse.y + 0.5f) - 0.5f);
    // RaycastHit2D r = Physics2D.Raycast(bod.bounds.center, transform.up, 0.1f);

    if (Input.GetKeyDown("space"))
        {
        Instantiate(crop, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }

}
