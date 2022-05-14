using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 14)
        {
            SceneManager.LoadScene("PrototypeScene");
        }
    }
}
