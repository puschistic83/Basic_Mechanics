using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class CoinsManager : MonoBehaviour
{    
    [SerializeField] private int _coinVictory;
    [SerializeField] private int _currentCoints;
    
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private AudioSource _audioSource;  

    private bool _coroutine = false;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();        
    }

    private void Update()
    {
        _coinVictory = SpawnBricks.CointVictory;

        if (_currentCoints >= _coinVictory && _coroutine == false)
        {            
            StartCoroutine(LoadSceneUp());                      
        }
    }
    public void CoinTarget()
    {
        _currentCoints++;
    }    
    IEnumerator LoadSceneUp()
    {
        _coroutine = true;
        GameObject.FindObjectOfType<TargetBall>().OnDestroy();
        _audioSource.PlayOneShot(_audioClip);
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
