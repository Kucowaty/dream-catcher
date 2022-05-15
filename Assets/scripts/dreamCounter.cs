using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dreamCounter : MonoBehaviour
{
    public dreams owca;
    public AudioSource beee;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 16)
        {
            owca.sheeeepies += 1;
            owca.sen += 10;
            beee.Play();
            Debug.Log("OWWWWCCCCAAAA");
            Destroy(gameObject, 0.5f);
            Destroy(this);
        }
    }
}
