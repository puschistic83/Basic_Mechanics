using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(PlayerController), typeof(LiveComponent))]
public class AnimatorController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    [SerializeField] private bool _hit;
    [SerializeField] private bool _die;
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private LiveComponent _liveComponent;
    
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerController = GetComponent<PlayerController>();
        _liveComponent = GetComponent<LiveComponent>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && _playerController.IsMove == true && _liveComponent.HitDamage == false)
        {
            _animator.SetBool("Run", true);
            _animator.SetBool("Walk", false);
        }
        else
        {
            if (_playerController.IsMove == true && _liveComponent.HitDamage == false)
            {
                _animator.SetBool("Walk", true);
                _animator.SetBool("Run", false);
            }
            else
            {
                _animator.SetBool("Walk", false);
                _animator.SetBool("Run", false);
            }
        }        
        
        if(_liveComponent.HitDamage == true && _liveComponent._isAlive == true)
        {
            _animator.SetTrigger("Hit");
        }
        if (_die == false && _liveComponent._isAlive == false)
        {            
            _die = true;
            _animator.SetTrigger("Die");
            _playerController.enabled = false;
        }
    }

}
