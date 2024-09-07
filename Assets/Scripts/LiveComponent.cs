using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LiveComponent : MonoBehaviour
{
    [SerializeField] private bool _isAlive = true;

    [SerializeField] private int _hp;
    [SerializeField] private int _maxHp;    

    [SerializeField] private TextMeshProUGUI _textLive;

    
    private void Start()
    {
        _textLive.text = _hp.ToString();
    }
      
   public bool Live(int hp)
    {
        if (_isAlive == false)
        {
            return false;
        }
        if (_hp >= _maxHp)
        {
            return false;
        }
        _hp += hp;
        return true;
    }

    public void Damage(int damage)
    {
        _hp -= damage;
    }    
}
