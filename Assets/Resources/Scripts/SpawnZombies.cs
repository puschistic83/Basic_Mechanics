using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombies : MonoBehaviour
{
    public Waves _waves;

    public GameObject ZombieGirl;
    public float SpawnTime;

    public float minSpawnTime = 5f;
    public float maxSpawnTime = 15f;

    void Start()
    {
        _waves = FindObjectOfType<Waves>();

        ZombieGirl = Resources.Load("Prefabs/ZombieGirl") as GameObject;
        StartCoroutine("WaitTimeForSpawn");
    }

   IEnumerator WaitTimeForSpawn()
    {
        while (true)
        {
            if(_waves.ZombieCount.Length < _waves.maxZombiesOnWave)
            {
                SpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
                yield return new WaitForSeconds(SpawnTime);
                Instantiate(ZombieGirl.gameObject, gameObject.transform.position, Quaternion.identity);
            }
            else
            {
                yield return new WaitForSeconds(SpawnTime);
            }
            
        }
    }
}
