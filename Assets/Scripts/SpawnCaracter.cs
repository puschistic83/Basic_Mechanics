using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCaracter : MonoBehaviour
{
    public Caracter caracter;

    public Transform point;
    public Transform point2;

    public int Enemy;
    public int Ally;

    private void Start()
    {
        int caracterSpawn = Enemy + Ally;
        for (int i = 0; i < caracterSpawn; i++)
        {
            if (i < Enemy)
            {
               Caracter newCaracer = Instantiate(caracter, point.position + new Vector3(i, 1, 0), Quaternion.identity);
                newCaracer.GetComponent<ColorManager>().EnemyAlly = true;
                newCaracer.name = $"Enemy {i}";
                newCaracer.gameObject.SetActive(true);
                

            }
            else
            {
                Caracter newCaracter2 = Instantiate(caracter, point2.position + new Vector3(i -6, 1, 0), Quaternion.identity);
                newCaracter2.name = $"Ally {i}";
                newCaracter2.gameObject.SetActive(true);
            }
        }

    }
}
