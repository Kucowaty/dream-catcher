using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chloroform : MonoBehaviour
{

    public dreams chlor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 15)
        {
            chlor.sen = 100;
            chlor.gamestatus = true;
            Destroy(this);
        }
    }
}
