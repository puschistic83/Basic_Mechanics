using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRocket : MonoBehaviour
{
    private TurrelRotate _turrelRotate;
    private ReloadingRocket _reloadingRocket;

    [SerializeField] private Transform[] _pointRocket;
    [SerializeField] private float _timeBetweenShots = 1f;

    private int _curerentRocket;
    private int _pointRocketIndex;

    private bool _fire;    

    private void Start()
    {
        _turrelRotate = GetComponent<TurrelRotate>();
        _reloadingRocket = GetComponent<ReloadingRocket>();
    }

    private void Update()
    {
        if(_turrelRotate.LockTarget == true && _curerentRocket == 8 && _fire == false)
        {
            
            _fire = true;
            StartCoroutine(Fire());
            
        }       
    }

    public void Turrel()
    {
        _curerentRocket = 8;
    }

    private IEnumerator Fire()
    {
        while (_curerentRocket > 0)
        {
            _curerentRocket--;
            var Rocket = _pointRocket[_pointRocketIndex].GetComponentInChildren<RoketMove>();
            Rocket.GetComponent<RoketMove>().enabled = true;
            _pointRocketIndex = (_pointRocketIndex + 1) % _pointRocket.Length;
            yield return new WaitForSeconds(_timeBetweenShots);            
        }
        _fire = false;
    }
}
