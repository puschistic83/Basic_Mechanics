using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{
    public GameObject[] ZombieCount;
    public int maxZombiesOnWave = 10;
    public int ZombieKillsOnWave;

    private void Update()
    {
        if(ZombieKillsOnWave >= maxZombiesOnWave)
        {
            ChageWave();
        }
        CountZombiesOfWave();
    }

    void CountZombiesOfWave()
    {
        ZombieCount = GameObject.FindGameObjectsWithTag("Zombie");
    }
    void ChageWave()
    {
        maxZombiesOnWave++;
        ZombieKillsOnWave = 0;

        for(int countZombies = 0; countZombies < ZombieCount.Length; countZombies++)
        {
            Destroy(ZombieCount[countZombies].gameObject); 
        }
    }
}
