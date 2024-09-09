using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LiveComponent : MonoBehaviour
{
    public static bool _isAlive = true;
    public static bool HitDamage = false; 

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
        if (_hp >= _maxHp)
        {
            _hp = _maxHp;
        }
        _textLive.text = _hp.ToString();
        return true;
    }

    public void Damage(int damage)
    {           
        _hp -= damage;
        _textLive.text = _hp.ToString();
        if (_hp <= 0)
        {
            _isAlive = false;
        }
        HitDamage = true;
        Invoke("Hit", 0.5f);
    }
    public void Hit()
    {
        HitDamage = false;
    }

}
