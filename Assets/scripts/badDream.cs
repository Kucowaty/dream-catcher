using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badDream : MonoBehaviour
{
    //public static dreams spanie = new dreams();
    public dreams spanie;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Budzik());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Budzik()
    {
        spanie.sen -= 1;
        Debug.Log("budzenie");
        yield return new WaitForSeconds(2);
        
        StartCoroutine(Budzik());
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 14)
        {
            Destroy(gameObject);
        }
    }
}
