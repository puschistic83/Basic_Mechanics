using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LiveComponent : MonoBehaviour
{
    [SerializeField] private int _hp;
    [SerializeField] private int _maxhp;
    public bool MaxHp;

    [SerializeField] private TextMeshProUGUI _textLive;

    private void Start()
    {
        _textLive.text = _hp.ToString();
    }

    public void Live(int hp)
    {        
        if(_hp < _maxhp)
        {
            _hp += hp;
            _textLive.text = _hp.ToString();
            if (_hp > _maxhp)
            {
                _hp = _maxhp;
            }
        }        
    }

    public void Damage(int damage)
    {
        _hp -= damage;
    }
    
    private void Update()
    {
        if (_hp >= _maxhp)
        {
            MaxHp = true;
        }
        else
        {
            MaxHp = false;
        }
    }
}
