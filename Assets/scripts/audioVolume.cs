using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioVolume : MonoBehaviour
{

    public AudioSource lv1;
    //public AudioSource lv2;
    //public AudioSource lv3;
    //public AudioSource lv4;
    //public AudioSource lv5;

    public float soundON = 1f;
    public float soundOFF = 0f;
    // Start is called before the first frame update
    void Start()
    {
        lv1 = GetComponent<AudioSource>();
        //lv2 = GetComponent<AudioSource>();
        //lv3 = GetComponent<AudioSource>();
        //lv4 = GetComponent<AudioSource>();
        //lv5 = GetComponent<AudioSource>();

        lv1.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            lv1.volume = soundON;
        }

        if (Input.GetKey(KeyCode.E))
        {
            lv1.volume = soundOFF;
        }
    }
}
