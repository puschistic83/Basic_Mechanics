using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBall : MonoBehaviour
{
    [SerializeField] private CoinsManager _cointTarget;

    private void Start()
    {
        _cointTarget = GameObject.FindObjectOfType<CoinsManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Target>())
        {
           Destroy(collision.gameObject);
            _cointTarget.CoinTarget();
        }
    }
}
