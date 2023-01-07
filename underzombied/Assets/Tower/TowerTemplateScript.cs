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
    public BoxCollider2D bod;
    public LayerMask towerLayer;

     // Start is called before the first frame update
    void Start()
    {
        Cost = 100;
        money = GameObject.FindGameObjectWithTag("Money");
    }

    // Update is called once per frame
    void Update()
    {
        int s = money.GetComponent<MoneyScript>().getMoney();
        Debug.Log(s);
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(Mathf.Round(mouse.x + 0.5f) -0.5f, Mathf.Round(mouse.y + 0.5f) - 0.5f);
        RaycastHit2D r = Physics2D.Raycast(bod.bounds.center, transform.up, 0.1f, towerLayer);

        if (Input.GetMouseButtonDown(0) && tilemap.HasTile(new Vector3Int(Mathf.FloorToInt(Mathf.Round(mouse.x + 0.5f) -0.5f), Mathf.FloorToInt(Mathf.Round(mouse.y + 0.5f) - 0.5f))) && money.GetComponent<MoneyScript>().getMoney() >= Cost){
            Instantiate(tower, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            money.GetComponent<MoneyScript>().takeMoney(100);
        }
        if (Input.GetMouseButtonDown(1)){
            Destroy(gameObject);
        }
        if (Input.GetKeyDown("space"))
            {
            Debug.Log("placed a crop");
            }
    }
}
