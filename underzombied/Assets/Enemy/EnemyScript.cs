using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject money;
    public BoxCollider2D bod;

    public int health = 100;

    private int dieCoins = 1;

    private string id = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

    private GameObject soundbar;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void HitByTower(int damage)
    {
        health -= damage;
        Debug.Log("I am die: " + id + " health: " + health);
        if (health <= 0)
            {
            if (gameObject != null)
                money.GetComponent<MoneyScript>().addMoney(dieCoins);

                soundbar = GameObject.FindWithTag("soundbar");
                soundbar.GetComponent<AudioManagerScript>().Play("enemyDie");

                Destroy(gameObject); // instance management
            }
    }
}
