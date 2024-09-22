using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class TargetBall : MonoBehaviour
{
    [SerializeField] private CoinsManager _cointTarget;
    [SerializeField] private AudioClip _clip;
    [SerializeField] private AudioClip _clipTarget;
    [SerializeField] private AudioSource _audioSource;

    private void Awake()
    {
        _cointTarget = GameObject.FindObjectOfType<CoinsManager>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Target>())
        {
           Destroy(collision.gameObject);
            _cointTarget.CoinTarget();
            _audioSource.PlayOneShot(_clipTarget);
        }
        _audioSource.PlayOneShot(_clip);
    }

    public void OnDestroy()
    {
        Destroy(gameObject);
    }
}
