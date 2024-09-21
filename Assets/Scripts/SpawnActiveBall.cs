using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnActiveBall : MonoBehaviour
{
    [SerializeField] private SpawnBall _spawnBall;

    private void Start()
    {
        _spawnBall = GameObject.FindObjectOfType<SpawnBall>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("!");
        var ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            Destroy(collision.gameObject);
            _spawnBall.NewSpawnBall();
        }
    }
}
