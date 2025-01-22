using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    [SerializeField] private Transform _barrel;
    [SerializeField] private Bullet _buletPrefab;
    [SerializeField] private int _countInClip;
    [SerializeField] private float _force;
    [SerializeField] private float _shotDelay;

    public override void Attak()
    {
        base.Attak();
    }

}
