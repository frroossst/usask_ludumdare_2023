using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TowerTemplateScript : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject tower;
    private Vector2 mouse;
    public GameObject money;
    public int Cost;
    // Start is called before the first frame update
    void Start()
    {
        Cost = 100;
    }

    // Update is called once per frame
    void Update()
    {
        int s = money.GetComponent<MoneyScript>().getMoney();
        Debug.Log(s);
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(Mathf.Round(mouse.x + 0.5f) -0.5f, Mathf.Round(mouse.y + 0.5f) - 0.5f);

        if (Input.GetMouseButtonDown(0) && tilemap.HasTile(new Vector3Int(Mathf.FloorToInt(Mathf.Round(mouse.x + 0.5f) -0.5f), Mathf.FloorToInt(Mathf.Round(mouse.y + 0.5f) - 0.5f))) && money.GetComponent<MoneyScript>().getMoney() >= Cost){
            Instantiate(tower, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            tilemap.SetTile(new Vector3Int(Mathf.FloorToInt(Mathf.Round(mouse.x + 0.5f) -0.5f), Mathf.FloorToInt(Mathf.Round(mouse.y + 0.5f) - 0.5f)),null);
            money.GetComponent<MoneyScript>().takeMoney(100);
        }
    }
}
