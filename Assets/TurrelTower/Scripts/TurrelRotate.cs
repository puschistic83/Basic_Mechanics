using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class TurrelRotate : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Transform _tower;
    private Transform _turrel;
    [SerializeField] private float _distaceToTarget;
    [SerializeField] private float _speedRotate;    
    [SerializeField] private float _minElevationAngle = -10f;
    [SerializeField] private float _maxElevationAngle = 60f;

    public bool LockTarget;

    private void Start()
    {
        _tower = GameObject.FindAnyObjectByType<TowerMarker>().GetComponent<Transform>();
        _turrel = GameObject.FindAnyObjectByType<TurrelMarker>().GetComponent<Transform>();
    }

    private void Update()
    {
        if (_target == null) return;
        if (Vector3.Distance(transform.position, _target.position) < _distaceToTarget)
        {
            // Получаем направление к цели
            Vector3 direction = (_target.position - _tower.position).normalized;
            // Вычисляем угол для вращения по оси Y
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            // Вращаем башню
            _tower.rotation = Quaternion.Slerp(_tower.rotation, lookRotation, _speedRotate * Time.deltaTime);

            
            float angle = Mathf.Clamp(Mathf.Atan2(direction.y, direction.magnitude) * Mathf.Rad2Deg, _minElevationAngle, _maxElevationAngle);
            Vector3 newRotation = new Vector3(angle, _turrel.localEulerAngles.y, 0);
            _turrel.localEulerAngles = -newRotation;
            
            LockTarget = true;
        }
        else
        {
            LockTarget = false;
        }
    }    
}