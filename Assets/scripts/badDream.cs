using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badDream : MonoBehaviour
{
    //public static dreams spanie = new dreams();
    public dreams spanie;

    public AudioSource popSound;
    public AudioSource bark;
    public AudioSource bark1;


    public int barkin;
    // Start is called before the first frame update
    void Start()
    {
        barkin = 1;
        popSound = GetComponent<AudioSource>();
        StartCoroutine(Budzik());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Budzik()
    {
        barkin = Random.Range(1, 4);
        if(barkin == 1)
        {
            bark.Play();
        }

        if (barkin == 2)
        {
            bark1.Play();
        }

        spanie .sen -= 1;
        //Debug.Log("budzenie");
        yield return new WaitForSeconds(Random.Range(2,5));
        
        if(spanie.gamestatus == true)
        {
            StartCoroutine(Budzik());
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 14)
        {
            popSound.Play();
            Destroy(this);
        }

        
    }

    public void Remover()
    {

    }
}
