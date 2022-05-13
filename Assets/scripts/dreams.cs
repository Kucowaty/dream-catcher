using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dreams : MonoBehaviour
{
    public GameObject sen_good;
    //public GameObject sen_mid;
    public GameObject sen_bad;

    public int jakosc_snu;
    public int rodzajSnu;

    public Text spanko;

    public int sen;

    public bool stage1;
    // Start is called before the first frame update
    void Start()
    {
        rodzajSnu = Random.Range(1, 2);
        StartCoroutine(Dream());
        jakosc_snu = 1;
        sen = 100;
    }

    // Update is called once per frame
    void Update()
    {
        spanko.text = sen.ToString();
    }

    IEnumerator Dream()
    {
        rodzajSnu = Random.Range(1, 3);
        switch (rodzajSnu)
        {
            case 1: createGoodDream();
                break;
            case 2: createBadDream();
                break;
        }
        yield return new WaitForSeconds(3);
        StartCoroutine(Dream());
    }

    IEnumerator DreamPointsFixes()
    {
        yield return new WaitForSeconds(1);
        sen += 1;
        StartCoroutine(DreamPointsFixes());
    }

    private void createGoodDream()
    {
        Instantiate(sen_good, randomPosition(), transform.rotation);
        Debug.Log("dobre spanko");
    }

    private void createBadDream()
    {
        Instantiate(sen_bad, randomPosition(), transform.rotation);
        Debug.Log("zle spanko");
    }


    private Vector3 randomPosition()
    {
        float x = Random.Range(-2, 2);
        float y = 2;
        float z = Random.Range(-2, 2);
        return new Vector3(x, y, z);
    }
    
    
}
