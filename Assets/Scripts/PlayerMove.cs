using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speedMove = 5;
    [SerializeField] float _speedRotate = 5;

    [SerializeField] bool _transformRigidbody;

    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] float _force;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float axisX = Input.GetAxis("Horizontal");
        float axisZ = Input.GetAxis("Vertical");        
        Vector3 moveObject = new Vector3(axisX, 0, axisZ);
        moveObject.Normalize();

        if (!_transformRigidbody)
        {
            transform.Translate(moveObject * _speedMove * Time.deltaTime, Space.World);
        }
        else
        {
            _rigidbody.velocity = moveObject * _force;
          //  _rigidbody.AddForce(moveObject * _force);
        }
        if(moveObject != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(moveObject, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, _speedRotate * Time.deltaTime);
        }
    }
}
