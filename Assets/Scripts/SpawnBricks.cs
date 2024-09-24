using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class SpawnBricks : MonoBehaviour
{
    [SerializeField] private GameObject _brick;
    [SerializeField] Transform point;
    
    [SerializeField] private Color[] _colors;

    [SerializeField] private int _brickInRow;
    [SerializeField] private float _brickWidth = 1;
    [SerializeField] private float _brickHeit = 0.5f;

    private int _currentRow = 0;
    private int _currentBrickRow = 0;
    private Color _currentCollor;

    public static int CointVictory;

    
    private void Start()
    {
        for (int i = 0; i < _colors.Length; i++)
        {
            _currentCollor = _colors[i];
            PlaceBrick();
        }

        CointVictory = _brickInRow * _colors.Length;
    }
    public void PlaceBrick()
    {
        _brickWidth = Mathf.Clamp(_brickWidth, 0.9f, 1.5f);
        _brickHeit = Mathf.Clamp(_brickHeit, 0.3f, 1f);
        if (_brickWidth > 1)
        {
            _brickInRow = 8;
        }
        for (int i = 0; i < _brickInRow; i++)
        {
            float xPositionBrick = _currentBrickRow * _brickWidth;
            float yPositionBrick = _currentRow * _brickHeit;

            var newBrick = Instantiate(_brick, point.position + new Vector3(xPositionBrick * 1.2f, yPositionBrick * -0.6f, 0), Quaternion.identity);
            newBrick.transform.parent = point.transform;
            newBrick.GetComponent<Renderer>().material.color = _currentCollor;
            _currentBrickRow++;

            if (_currentBrickRow >= _brickInRow)
            {
                _currentRow++;
                _currentBrickRow = 0;
            }
        }
    }    
}
