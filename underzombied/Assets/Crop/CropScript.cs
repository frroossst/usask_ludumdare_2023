using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropScript : MonoBehaviour
{
    public float timeToWait;

    public int goldHarvest;

    public GameObject money;

    private float startTime = 0.0f;

    private GameObject parentSpawnner;

    // Start is called before the first frame update
    void Start()
    {
    parentSpawnner = GameObject.FindWithTag("cropSpawnner");
    }

    // Update is called once per frame
    void Update()
    {
    this.startTime = this.startTime + Time.deltaTime;
    if (this.startTime >= timeToWait)
        {
        money.GetComponent<MoneyScript>().addMoney(goldHarvest);
        if (parentSpawnner != null)
            {
            parentSpawnner.GetComponent<CropSpawnerScript>().setSpawanClear(transform.position);
            }
        Destroy(gameObject);
        }
        
    }
}
