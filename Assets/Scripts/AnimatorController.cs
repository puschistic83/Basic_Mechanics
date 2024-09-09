using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    [SerializeField] private bool _hit;
    [SerializeField] private bool _die;
    [SerializeField] private PlayerController _playerController;
    
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerController = GetComponent<PlayerController>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && PlayerController._move == true && LiveComponent.HitDamage == false)
        {
            _animator.SetBool("Run", true);
            _animator.SetBool("Walk", false);
        }
        else
        {
            if (PlayerController._move == true && LiveComponent.HitDamage == false)
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
        
        if(LiveComponent.HitDamage == true && LiveComponent._isAlive == true)
        {
            _animator.SetTrigger("Hit");
        }
        if (_die == false && LiveComponent._isAlive == false)
        {            
            _die = true;
            _animator.SetTrigger("Die");
            _playerController.enabled = false;
        }
    }

}
