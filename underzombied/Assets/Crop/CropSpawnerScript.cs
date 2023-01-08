using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class CropSpawnerScript : MonoBehaviour
{
    public GameObject panel;
    public GameObject Background;
    private Vector3 referencevector = new Vector3(0.0f, 0.0f, 0.0f);
    public GameObject crop;
    public GameObject Selected;
    public float timeAlive;
    public GameObject money;
    public int price;

    private GameObject globalDataStructures;

    // private SortedDictionary<int, Vector3> spawn_map = new SortedDictionary<int, Vector3>();

    // protected bool[] map_occupied = new bool[15];

    private SortedDictionary<int, Vector3> spawn_map;
    private bool[] map_occupied;

    private Vector3 getSpawnLocation()
        {
        foreach (int key in spawn_map.Keys)
            {
            if (map_occupied[key] == false)
                {
                map_occupied[key] = true;
                return spawn_map[key];
                }
            }
        return referencevector;
        }

    public void setSpawanClear(Vector3 curr_location)
        {
        foreach (int key in spawn_map.Keys)
            {
            if (curr_location.Equals(spawn_map[key]))
                {
                map_occupied[key] = false;
                }
            }
        // map_occupied[idx] = false;
        // yield return StartCoroutine(sleepFor());
        // map_occupied[idx] = false;
        }

    private IEnumerator sleepFor()
        {
        yield return new WaitForSeconds(timeAlive);
        }


    // Start is called before the first frame update
    void Start()
    {
    globalDataStructures = GameObject.FindWithTag("globalPlots");

    panel.SetActive(false);
    // for (int i = 0; i < 15; i++)
    //     {
    //     map_occupied[i] = false;
    //     }

    // spawn_map.Add(0,  new Vector3(19.0300f, 5.8700f, -0.001f));
    // spawn_map.Add(1,  new Vector3(22.0668f, 5.9600f, -0.001f));
    // spawn_map.Add(2,  new Vector3(25.0400f, 6.0500f, -0.001f));

    // spawn_map.Add(3,  new Vector3(18.9668f, 2.9843f, -0.001f));
    // spawn_map.Add(4,  new Vector3(22.0300f, 2.9843f, -0.001f));
    // spawn_map.Add(5,  new Vector3(24.9500f, 2.9700f, -0.001f));

    // spawn_map.Add(6,  new Vector3(18.9668f, 0.0200f, -0.001f));
    // spawn_map.Add(7,  new Vector3(22.0300f, -0.090f, -0.001f));
    // spawn_map.Add(8,  new Vector3(25.0300f, 0.0000f, -0.001f));

    // spawn_map.Add(9,  new Vector3(18.9668f, -2.970f, -0.001f));
    // spawn_map.Add(10, new Vector3(21.9400f, -3.010f, -0.001f));
    // spawn_map.Add(11, new Vector3(24.9600f, -3.010f, -0.001f));

    // spawn_map.Add(12, new Vector3(18.9668f, -5.940f, -0.001f));
    // spawn_map.Add(13, new Vector3(22.0600f, -5.940f, -0.001f));
    // spawn_map.Add(14, new Vector3(25.0400f, -5.940f, -0.001f));
    }

    // Update is called once per frame
    void Update()
    {
    this.spawn_map = globalDataStructures.GetComponent<GlobalPlotsScript>().getGlobalHashMap();
    this.map_occupied = globalDataStructures.GetComponent<GlobalPlotsScript>().getGlobalArray();
    }

    void OnMouseDown()
        {
            if (Selected.GetComponent<SelectedScript>().getSelected() == 0){
                // Vector3 location = new Vector3(0.0f, 0.0f, -1.0f);
                Vector3 location = getSpawnLocation();
                if (!location.Equals(referencevector) && money.GetComponent<MoneyScript>().getMoney() >= price)
                    {
                    Instantiate(crop, location, Quaternion.identity);
                    money.GetComponent<MoneyScript>().takeMoney(price);
                    }
                }
            }
        
    
    void OnMouseEnter(){
        Background.GetComponent<SpriteRenderer>().color = Color.yellow;
        panel.SetActive(true);
    }
    void OnMouseExit(){
        Background.GetComponent<SpriteRenderer>().color = Color.white;
        panel.SetActive(false);
    }
}
