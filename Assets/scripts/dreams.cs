using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dreams : MonoBehaviour
{
    public GameObject sen_good;
    //public GameObject sen_mid;
    //public GameObject sen_bad;

    public int jakosc_snu;

    public bool stage1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Dream());
        jakosc_snu = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Dream()
    {        
        Instantiate(sen_good, transform.position, transform.rotation);
        
        yield return new WaitForSeconds(3);
        StartCoroutine(Dream());
    }
}
