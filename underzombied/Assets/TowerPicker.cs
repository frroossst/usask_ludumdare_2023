using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPicker : MonoBehaviour
{
    public GameObject towerTemplate;
    public GameObject Background;
    public int selected;
    // Start is called before the first frame update
    void Start()
    {
        selected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)){
            selected = 0;
            Background.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
    void OnMouseDown(){
        Instantiate(towerTemplate, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        selected = 1;
    }
    void OnMouseEnter(){
        Background.GetComponent<SpriteRenderer>().color = Color.yellow;
    }
    void OnMouseExit(){
        if (selected == 0){
            Background.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
