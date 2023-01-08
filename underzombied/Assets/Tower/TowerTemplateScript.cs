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
    public GameObject rangeView;

    private GameObject soundbar;
    public float timer = 0f;

     // Start is called before the first frame update
    void Start()
    {
        rangeView.GetComponent<RangeScript>().setSize(tower.GetComponent<TowerScript>().range * 2);
        Instantiate(rangeView, transform.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {   
        if (timer > 0.1f){
            int s = money.GetComponent<MoneyScript>().getMoney();
            Debug.Log(s);
            mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(Mathf.Round(mouse.x + 0.5f) -0.5f, Mathf.Round(mouse.y + 0.5f) - 0.5f, -1);
            RaycastHit2D r = Physics2D.Raycast(bod.bounds.center, transform.up, 0.1f, towerLayer);

            if (Input.GetMouseButtonDown(0) && tilemap.HasTile(new Vector3Int(Mathf.FloorToInt(Mathf.Round(mouse.x + 0.5f) -0.5f), Mathf.FloorToInt(Mathf.Round(mouse.y + 0.5f) - 0.5f))) && r.collider == null)
                {
                if (money.GetComponent<MoneyScript>().getMoney() >= Cost )
                    {
                    Instantiate(tower, new Vector3(transform.position.x, transform.position.y, -1), Quaternion.identity);
                    money.GetComponent<MoneyScript>().takeMoney(Cost);
                    }
                else
                    {
                    soundbar = GameObject.FindWithTag("soundbar");
                    soundbar.GetComponent<AudioManagerScript>().Play("noMoney");
                    }
            }
            if (Input.GetMouseButtonDown(1)){
                Destroy(gameObject);
            } 
        }
        else{
            timer = timer + Time.deltaTime;
        }
        
    }
}
