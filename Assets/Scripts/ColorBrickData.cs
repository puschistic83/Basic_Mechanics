using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorBrickData", menuName = "ColorBrick Data", order = 51)]
public class ColorBrickData : ScriptableObject
{
    [SerializeField] private Color[] _colors;

    [SerializeField] private int _brickInRow; 

    public Color[] Colors
    {
        get
        {
            return _colors;
        }
    }

    public int BrickRow
    {
        get
        {
            return _brickInRow;
        }
    }
}
