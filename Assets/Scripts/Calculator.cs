using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{    
    public string baseDamage;
    public string multiplier;

    public string damage;

    private void OnValidate()
    {
        First();
    }

    private void First()
    {
        float X = float.Parse(baseDamage);
        float Y = float.Parse(multiplier);
        
        damage = (X * Y).ToString();
    }
}
