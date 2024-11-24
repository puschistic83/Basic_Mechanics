using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ReloadingRocket : MonoBehaviour
{
    [SerializeField] private Transform[] _pointsSpawn;
    [SerializeField] private int _totalRocket = 8;
    [SerializeField] private float _reloadTime = 1f;

    private int _curerentRocket;
    private int _pointSpawnIndex;
    public bool _chargedTurrel;

    private PoolRocket _pool;
    private int _poolRocket;

    private FireRocket _fireRocket;

    private void Start()
    {
        _curerentRocket = _totalRocket;
        _pool = GetComponent<PoolRocket>();
        StartCoroutine(ReloadingStart());        
        _fireRocket = GetComponent<FireRocket>();
    }   

    private IEnumerator ReloadingStart()
    {
        while (_curerentRocket > 0)
        {
            yield return new WaitForSeconds(_reloadTime);
            var Rocket = _pool.GetFreeElement();           
            Rocket.transform.position = _pointsSpawn[_pointSpawnIndex].position;
            Rocket.transform.rotation = _pointsSpawn[_pointSpawnIndex].rotation;
            Rocket.transform.parent = _pointsSpawn[_pointSpawnIndex].transform;
            _curerentRocket--;
            _pointSpawnIndex = (_pointSpawnIndex + 1) % _pointsSpawn.Length;
        }
        _fireRocket.Turrel();
        _chargedTurrel = false;
    }

    public void RocketInPool()
    {
        _poolRocket++;

        if (_poolRocket == _totalRocket && _chargedTurrel == false)
        {
            _poolRocket = 0;
            _curerentRocket = _totalRocket;
            StartCoroutine(ReloadingStart());
            _chargedTurrel = true;
        }
    }
}
