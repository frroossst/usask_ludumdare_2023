using System.Collections.Generic;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public AudioSource addMoneySound;

    public AudioSource takeMoneySound;

    public AudioSource laserShootSound;

    public AudioSource enemyDieSound;

    private List<AudioSource> soundsToPlay;

    // Start is called before the first frame update
    void Start()
    {
        soundsToPlay = new List<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    foreach (AudioSource item in soundsToPlay)
    {
        item.Play();
        Debug.Log("playing sound");
    }
    soundsToPlay.Clear();
    }

    public void Play(string type)
        {
        if (type.Equals("addMoney"))
            {
            soundsToPlay.Add(addMoneySound);
            }
        else if (type.Equals("takeMoney"))
            {
            soundsToPlay.Add(takeMoneySound);
            }
        else if (type.Equals("laserShoot"))
            {
            soundsToPlay.Add(laserShootSound);
            }
        else if (type.Equals("enemyDie"))
            {
            soundsToPlay.Add(enemyDieSound);
            }
        
        }
}
