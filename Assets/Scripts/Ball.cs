using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{    
    [SerializeField] private bool _startBall = false;
    
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _force;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _startBall == false)
        {
            _startBall = true;            
            _rigidbody.AddForce(Vector3.up * _force, ForceMode.Impulse);
            transform.SetParent(null);
        }
    }
}
