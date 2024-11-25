using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explossion : MonoBehaviour
{
    private ObjectPool _poolObject;
    [SerializeField] private float _timeExplossion = 6;

    private void Start()
    {
        _poolObject = GameObject.FindObjectOfType<ObjectPool>();
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
            GameObject prefabExplossion = _poolObject.prefabs[1];
            _poolObject.ReturnObject(prefabExplossion, gameObject);
        }
    }   
}
