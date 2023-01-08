using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{
    public BoxCollider2D bod;
    public LayerMask Enemy;
    private float readyFire;
    public float threshold;
    private float x;
    private float y;
    private int xFlip;
    private int yFlip;
    public LineRenderer laser;
    public GameObject selected;
    public float range;
    public int damage;
    public float fireTime;

    private GameObject soundbar;

    // Start is called before the first frame update
    void Start()
    {
        readyFire = threshold;
        fireTime = 0.5f;
        x = 1;
        y = 0;
        xFlip = -1;
        yFlip = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (readyFire >= 1){
            RaycastHit2D r = Physics2D.Raycast(bod.bounds.center, new Vector2(x,y), range, Enemy);
            Debug.DrawRay(bod.bounds.center, new Vector3(x,y, 0) * (range), Color.black);
            x = x + 2f * xFlip * Time.deltaTime * 2;
            y = y + 2f * yFlip * Time.deltaTime * 2;
            if (x >= 1){
                xFlip = -1;
            }
            else if (x <= -1){
                xFlip = 1;
            }
            if (y >= 1){
                yFlip = -1;
            }
            else if (y <= -1){
                yFlip = 1;
            }
            if (r.collider != null){
                r.transform.SendMessage("HitByTower", damage);
                readyFire = 0;
                laser.SetPosition(0, new Vector3(transform.position.x, transform.position.y, transform.position.z));
                laser.SetPosition(1, r.point);
                laser.enabled = true;
                fireTime = 0;

                soundbar = GameObject.FindWithTag("soundbar");
                soundbar.GetComponent<AudioManagerScript>().Play("laserShoot");
            }
        }
        else{
            readyFire = readyFire + Time.deltaTime / threshold;
        }
        if (fireTime >= 0.5f){
            laser.enabled = false;
        } 
        fireTime = fireTime + Time.deltaTime;
    }
    
    void OnMouseOver(){
        if (Input.GetMouseButtonDown(1) && selected.GetComponent<SelectedScript>().getSelected() == 0){
            Destroy(gameObject);
        }
    }
}
