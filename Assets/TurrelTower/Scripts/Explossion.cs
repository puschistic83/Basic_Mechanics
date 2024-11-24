using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explossion : MonoBehaviour
{
    private PoolObject _poolObject;
    [SerializeField] private float _timeExplossion = 6;

    private void Start()
    {
        _poolObject = GetComponent<PoolObject>();
    }

    private void OnEnable()
    {
        _timeExplossion = 6;
    }

    void Update()
    {
        _timeExplossion -= Time.deltaTime;
        if ( _timeExplossion < 0 )
        {
            _poolObject.ReturnToPool();
        }
    }   
}
