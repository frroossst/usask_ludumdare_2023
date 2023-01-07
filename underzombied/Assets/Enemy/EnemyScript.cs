using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public BoxCollider2D bod;

    private string id = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HitByTower()
    {
        Debug.Log("I am die: " + id);
    }
}
