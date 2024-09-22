using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SpawnActiveBall : MonoBehaviour
{
    [SerializeField] private SpawnBall _spawnBall;

    [SerializeField] private AudioClip _clip;
    [SerializeField] private AudioSource _audioSource;

    private void Start()
    {
        _spawnBall = GameObject.FindObjectOfType<SpawnBall>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {        
        var ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            _audioSource.PlayOneShot(_clip);
            Destroy(collision.gameObject);
            _spawnBall.NewSpawnBall();
        }
    }
}
