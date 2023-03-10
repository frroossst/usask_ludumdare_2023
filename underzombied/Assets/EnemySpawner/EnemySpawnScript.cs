using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemySpawnScript : MonoBehaviour
    {
    [SerializeField]
    private GameObject defaultEnemy;

    private float defaultSwarmerInterval = 5f;
    private float counter = 0;
    private float spawnPoint_x = -15f;
    private float spawnPoint_y = -4f;
    private float spawnPoint_z = -1f;

    // Start is called before the first frame update
    void Start()
        {
        Debug.Log("default enemt in Start() " + defaultEnemy);
        StartCoroutine(spawnEnemy(defaultSwarmerInterval, defaultEnemy));
        }

    // Update is called once per frame
    void Update()
        {
        
        }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
        {
        if (enemy == null)
            {

            }
        else
            {
            counter++;
            if (counter % 7 == 0 && defaultSwarmerInterval > 0.3f)
                {
                    if (defaultSwarmerInterval <= 0.7f){
                        defaultSwarmerInterval = 0.3f;
                    }
                    else{
                        defaultSwarmerInterval -= 0.4f;
                    }
                
                }
            interval = defaultSwarmerInterval;

            yield return new WaitForSeconds(interval);
            try
                {
                GameObject newEnemy = Instantiate(enemy, new Vector3(spawnPoint_x, spawnPoint_y, spawnPoint_z), Quaternion.identity);
                }
            catch (Exception e)
                {
                Debug.Log("error: " + e);
                }
            StartCoroutine(spawnEnemy(interval, enemy));
            }
        }
    }
