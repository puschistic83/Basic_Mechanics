using System.Collections;
using UnityEngine;

public class SpawnHealthItems : MonoBehaviour
{
    [SerializeField] Transform[] _pointsSpawn;
    [SerializeField] GameObject _healthItem;
    [SerializeField] int _coint;
    [SerializeField] int _maxHealthItem;
    [SerializeField] int _timeBetweenSpawn;

    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
    } 

    private Transform RandomSpawnPoint()
    {
        var spawnPointIndex = Random.Range(0, _pointsSpawn.Length);
        var spawnPoint = _pointsSpawn[spawnPointIndex];
        return spawnPoint;
    }

    private void SpawnHealthItem()
    {
        var spawnPoint = RandomSpawnPoint();
        Instantiate(_healthItem, spawnPoint); 
    }       

    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            if (_coint >= _maxHealthItem)
            {
                yield return null;
                continue;
            }
            yield return new WaitForSeconds(_timeBetweenSpawn);
            SpawnHealthItem();
            _coint++;
        }        
    }
}
