using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    [SerializeField] private float _speedPlatform;

    [SerializeField] private float _left;
    [SerializeField] private float _right;
       
    private void Update()
    {
        // float axisX = Input.GetAxis("Horizontal");
        float axisX = 0;
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            axisX = -1;
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            axisX = 1;
        }
        
        Vector3 moveObject = new Vector3(axisX, 0, 0);       

        transform.Translate(moveObject * _speedPlatform * Time.deltaTime);
        var targetPosition = transform.position;

        targetPosition.x = Mathf.Clamp(transform.position.x, _left, _right);
        transform.position = targetPosition;                
    }
}
