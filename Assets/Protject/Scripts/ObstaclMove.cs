
using UnityEngine;

public class ObstaclMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _target;

    [SerializeField] private GameObject _point1;
    [SerializeField] private GameObject _point2;

    [SerializeField] private bool check;

    private void Update()
    {
        if (check)
        {
            _target.transform.position = Vector3.MoveTowards(_target.transform.position, _point1.transform.position, _speed * Time.deltaTime);
        }
        if (!check)
        {
            _target.transform.position = Vector3.MoveTowards(_target.transform.position, _point2.transform.position, _speed * Time.deltaTime);
        }

            if (_target.transform.position == _point1.transform.position)
        {
            check = !check;
        }
        if (_target.transform.position == _point2.transform.position)
        {
            check = !check;
        }
        
    }

}
