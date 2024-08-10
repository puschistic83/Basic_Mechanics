using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Example : MonoBehaviour
{
    public int hp = 10;
    public float damage = 2.5f;
    public bool die = false;

    public int scene = 1;

    private void Awake()
    {
        Debug.Log("HP = " + hp);
        Debug.LogWarning("Damage = " + damage);
        Debug.LogError("Die = " + die);
    }

    private void Start()
    {
        int health = hp - Convert.ToInt32( damage);
        Debug.Log("Health = " + health);
        hp = health;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            TakeDamage();
        }
        if (hp <= 0)
        {
            die = true;
        }
        if (die == true)
        {
            ManagerScene();
        }

    }
    private void TakeDamage()
    {
        hp -= Convert.ToInt32( damage );
        Debug.Log("HP = " + hp);
    }
    private void ManagerScene()
    {
        SceneManager.LoadScene(scene);
    }    
}
