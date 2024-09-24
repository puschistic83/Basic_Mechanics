using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class ScoreManager : MonoBehaviour
{    
    private int _scoreVictory;
    private int _currentScore;
    
    [SerializeField] private AudioClip _audioClip;
    private AudioSource _audioSource;  

    private bool _coroutine = false;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _scoreVictory = SpawnBricks.CointVictory;
    }
        
    public void ScoreBricks()
    {
        _currentScore++;

        if (_currentScore >= _scoreVictory && _coroutine == false)
        {
            StartCoroutine(LoadSceneUp());
        }
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
