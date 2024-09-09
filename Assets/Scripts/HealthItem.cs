using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{
    [SerializeField] private int _health;
        
    private void OnTriggerEnter(Collider other)
    {        
        if (other.TryGetComponent(out LiveComponent liveComponent))
        {           
            if (liveComponent.Live(_health))
            {
                Destroy(gameObject);
            }            
        }       
    }
}
