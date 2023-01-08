using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    public int CurrentMoney;

    private GameObject soundbar;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int getMoney(){
        return CurrentMoney;
    }
    public void addMoney(int MoneyAdded){
        CurrentMoney = CurrentMoney + MoneyAdded;
        soundbar = GameObject.FindWithTag("soundbar");
        soundbar.GetComponent<AudioManagerScript>().Play("addMoney");
    }
    public void takeMoney(int MoneyTaken){
        CurrentMoney = CurrentMoney - MoneyTaken;
        soundbar = GameObject.FindWithTag("soundbar");
        soundbar.GetComponent<AudioManagerScript>().Play("takeMoney");
    }
    public void initial(int StartingMoney){
        CurrentMoney = StartingMoney;
    }
}
