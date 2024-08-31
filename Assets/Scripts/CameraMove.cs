using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] GameObject _target;

    private void Update()
    {
        transform.position = _target.transform.position;
    }
}
