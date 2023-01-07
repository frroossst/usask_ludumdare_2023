using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
    {
    [SerializeField]
    private GameObject defaultEnemy;

    private float defaultSwarmerInterval = 3.5f;

    private float spawnPoint_x = -15f;
    private float spawnPoint_y = -4f;
    private float spawnPoint_z = -1f;

    // Start is called before the first frame update
    void Start()
        {
        StartCoroutine(spawnEnemy(defaultSwarmerInterval, defaultEnemy));
        }

    // Update is called once per frame
    void Update()
        {
        
        }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
        {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(spawnPoint_x, spawnPoint_y, spawnPoint_z), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
        }
    }
