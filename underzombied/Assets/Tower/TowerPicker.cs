using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPicker : MonoBehaviour
{
    public GameObject towerTemplate;
    public GameObject Background;
    public GameObject Selected;
    public int selected;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        selected = 0;
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(1)){
            selected = 0;
            Background.GetComponent<SpriteRenderer>().color = Color.white;
            Selected.GetComponent<SelectedScript>().setSelected(0);
        }
    }
    void OnMouseDown(){
        if (Selected.GetComponent<SelectedScript>().getSelected() == 0){
            Instantiate(towerTemplate, new Vector3(transform.position.x, transform.position.y, -0.9f), Quaternion.identity);
            selected = 1;
            Selected.GetComponent<SelectedScript>().setSelected(1);
        }
        
    }
    void OnMouseEnter(){
        Background.GetComponent<SpriteRenderer>().color = Color.yellow;
        panel.SetActive(true);
    }
    void OnMouseExit(){
        if (selected == 0){
            Background.GetComponent<SpriteRenderer>().color = Color.white;
        }
        panel.SetActive(false);
    }
}
