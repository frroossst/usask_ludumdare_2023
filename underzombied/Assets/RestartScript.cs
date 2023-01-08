using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene(1);
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(1);
        }
    }
    void OnMouseDown(){
        Debug.Log("clicked");
        SceneManager.LoadScene(1);
        
    }
}
