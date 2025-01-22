using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    private GameObject gun;

    void Start()
    {
        gun = GameObject.FindGameObjectWithTag("Gun");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gun.GetComponent<Gun>().BagAmmo = gun.GetComponent<Gun>().BagAmmo + 10;
            Destroy(gameObject);
        }
    }

}
