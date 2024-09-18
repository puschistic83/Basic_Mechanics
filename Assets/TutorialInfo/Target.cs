using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Coins Coins;        

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SSS"))
        {
            Coins.CoinTarget();
            
                Destroy(gameObject);
        }
    }
}
