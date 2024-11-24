using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoketMove : MonoBehaviour
{
    [SerializeField] private float _speed = 10;
    [SerializeField] private float _timeLive = 7;
    [SerializeField] private GameObject _effectFire;    

    private PoolObject _poolObject;
    private ReloadingRocket _reloadingRocket;

    private PoollExplossion _poollExplossion;
    
    private void Start()
    {
        _reloadingRocket = GameObject.FindAnyObjectByType<ReloadingRocket>();
        _poolObject = GetComponent<PoolObject>();
        _poollExplossion = GameObject.FindAnyObjectByType<PoollExplossion>();
    }

    private void OnEnable()
    {   
        _effectFire.SetActive(true);
        Invoke("ParentNull", 0.2f);
        _timeLive = 7;
        
    }
    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);  
        _timeLive -= Time.deltaTime;
        if(_timeLive < 0)
        {
            OnDestroy();
        }
    }

    private void ParentNull()
    {
        transform.SetParent(null);        
    }

    private void OnCollisionEnter(Collision collision)
    {
        OnDestroy();        
        var Explossion = _poollExplossion.GetFreeElement();
        Explossion.transform.position = transform.position;
        Explossion.transform.rotation = transform.rotation;
    }

    private void OnDestroy()
    {           
        GetComponent<RoketMove>().enabled = false;
        _effectFire.SetActive(false);        
        _reloadingRocket.RocketInPool();        
        _poolObject.ReturnToPool();
    }
}
