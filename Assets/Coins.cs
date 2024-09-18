using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coins : MonoBehaviour
{
    [SerializeField] private int _coin;
    [SerializeField] private int _scene;

    private void Update()
    {
        if(_coin == 18)
        {
            SceneManager.LoadScene(_scene);
        }
    }
    public void CoinTarget()
    {
        _coin++;
    }
}
