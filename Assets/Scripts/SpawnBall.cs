using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] private GameObject _ball;
    [SerializeField] private Transform _pointSpawn;

    private void Start()
    {
        if(_ball != null)
        {
            NewSpawnBall();           
        }
    }

    public void NewSpawnBall()
    {
       var ball = Instantiate(_ball, _pointSpawn.position, Quaternion.identity);
        ball.transform.parent = _pointSpawn;
    }


}
