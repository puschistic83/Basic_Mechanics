using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live : MonoBehaviour
{
    public int hp = 5;
    public int damage = 2;

    public bool isDeath;

    public void Damage(int damage)
    {
        hp -= damage;        
    }
    public void Death()
    {
        isDeath = true;
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage(damage);
        }
        if (hp <= 0)
        {
            hp = 0;
            Death();
        }
    }
}
