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
    public int startingMoney;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        round = 1;
        money.GetComponent<MoneyScript>().initial(startingMoney);
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
        moneytext.text = "Gold: \n" + money.GetComponent<MoneyScript>().getMoney();
    }
}
