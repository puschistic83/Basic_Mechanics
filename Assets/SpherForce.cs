using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherForce : MonoBehaviour
{
    [SerializeField] private float _force;

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Player"))

       
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += new Vector3(0, _force, 0);
            transform.SetParent(null);
        }
    }

}
