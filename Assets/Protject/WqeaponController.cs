using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WqeaponController : MonoBehaviour
{
    [SerializeField] private Weapon _weapon;

    [SerializeField] private List<Weapon> _weaponList;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _weapon.Attak();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _weapon.Recharge(); 
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            ChangeWeapon(_weaponList[1]);
        }
    }
    public void ChangeWeapon(Weapon newWeapon)
    {
        _weapon = newWeapon;
    }
}
