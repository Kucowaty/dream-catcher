using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class dreams : MonoBehaviour
{
    public GameObject sen_good;
    //public GameObject sen_mid;
    public GameObject sen_bad;

    public Slider slider;

    public int jakosc_snu;
    public int rodzajSnu;

    public Text spanko;

    public int sen;

    public bool stage1;

    public bool gamestatus;
    // Start is called before the first frame update
    void Start()
    {
        gamestatus = true;
        rodzajSnu = Random.Range(1, 2);
        StartCoroutine(Dream());
        jakosc_snu = 1;
        sen = 100;
    }

    // Update is called once per frame
    void Update()
    {
        spanko.text = sen.ToString();
        slider.value = sen;
        if(sen <= 0)
        {
            gamestatus = false;
            Debug.Log("End GAME");
        }
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
        if (gamestatus == true)
        {
            Instantiate(sen_good, PositionRandomizer.RandomPointInBounds("DreamZone"), transform.rotation);
            Debug.Log("dobre spanko");
        }
    }

    private void createBadDream()
    {
        if (gamestatus == true)
        {
            Instantiate(sen_bad, PositionRandomizer.RandomPointInBounds("DreamZone"), transform.rotation);
            Debug.Log("zle spanko");
        }
    }


    public void SetSleep(int sen)
    {
        slider.value = sen;
    }
    
    
}
