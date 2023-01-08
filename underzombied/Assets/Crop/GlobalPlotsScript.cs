using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalPlotsScript : MonoBehaviour
{
    protected SortedDictionary<int, Vector3> spawn_map = new SortedDictionary<int, Vector3>();

    protected bool[] map_occupied = new bool[15];

    // Start is called before the first frame update
    void Start()
    {
    // panel.SetActive(false);
    for (int i = 0; i < 15; i++)
        {
        map_occupied[i] = false;
        }

    spawn_map.Add(0,  new Vector3(19.0300f, 5.8700f, -0.001f));
    spawn_map.Add(1,  new Vector3(22.0668f, 5.9600f, -0.001f));
    spawn_map.Add(2,  new Vector3(25.0400f, 6.0500f, -0.001f));

    spawn_map.Add(3,  new Vector3(18.9668f, 2.9843f, -0.001f));
    spawn_map.Add(4,  new Vector3(22.0300f, 2.9843f, -0.001f));
    spawn_map.Add(5,  new Vector3(24.9500f, 2.9700f, -0.001f));

    spawn_map.Add(6,  new Vector3(18.9668f, 0.0200f, -0.001f));
    spawn_map.Add(7,  new Vector3(22.0300f, -0.090f, -0.001f));
    spawn_map.Add(8,  new Vector3(25.0300f, 0.0000f, -0.001f));

    spawn_map.Add(9,  new Vector3(18.9668f, -2.970f, -0.001f));
    spawn_map.Add(10, new Vector3(21.9400f, -3.010f, -0.001f));
    spawn_map.Add(11, new Vector3(24.9600f, -3.010f, -0.001f));

    spawn_map.Add(12, new Vector3(18.9668f, -5.940f, -0.001f));
    spawn_map.Add(13, new Vector3(22.0600f, -5.940f, -0.001f));
    spawn_map.Add(14, new Vector3(25.0400f, -5.940f, -0.001f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public SortedDictionary<int, Vector3> getGlobalHashMap()
        {
        return this.spawn_map;
        }

    public bool[] getGlobalArray()
        {
        return this.map_occupied;
        }
}
