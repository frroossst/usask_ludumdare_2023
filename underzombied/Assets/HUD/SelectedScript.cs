using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedScript : MonoBehaviour
{
    public int selected;
    // Start is called before the first frame update
    void Start()
    {
        selected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int getSelected(){
        return selected;
    }
    public void setSelected(int sel){
        selected = sel;
    }
}
