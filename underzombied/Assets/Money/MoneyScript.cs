using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    public int CurrentMoney;
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
    }
    public void takeMoney(int MoneyTaken){
        CurrentMoney = CurrentMoney - MoneyTaken;
    }
    public void initial(int StartingMoney){
        CurrentMoney = StartingMoney;
    }
}
