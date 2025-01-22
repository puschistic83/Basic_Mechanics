using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float Health = 50f;

  public void TakeDamage(float Amaunt)
    {
        Health = Health - Amaunt;
        if(Health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        gameObject.SetActive(false);
    }
}
