using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoundScript : MonoBehaviour
{
    public TMP_Text roundtext;
    public TMP_Text moneytext;
    public GameObject money;
    public int round;
    public float time;
    public float roundTime;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        round = 1;
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= roundTime){
            round = round + 1;
            roundtext.text = "Round: " + round;
            time = 0;
        }
        moneytext.text = "Money: \n" + money.GetComponent<MoneyScript>().getMoney();
    }
}
