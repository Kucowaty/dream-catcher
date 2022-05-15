using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGamePR : MonoBehaviour
{
    public dreams status;
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 14)
        {
            status.gamestatus = true;
        }
    }
}
