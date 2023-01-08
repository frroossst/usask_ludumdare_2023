using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
        if (goldHarvest == 69)
            {
            System.Random rnd = new System.Random();
            goldHarvest = rnd.Next(0, 50);
            }
        money.GetComponent<MoneyScript>().addMoney(goldHarvest);
        if (parentSpawnner != null)
            {
            parentSpawnner.GetComponent<CropSpawnerScript>().setSpawanClear(transform.position);
            }
        Destroy(gameObject);
        }
        
    }
}
