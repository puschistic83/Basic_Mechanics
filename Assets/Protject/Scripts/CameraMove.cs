using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] GameObject _target;

    private void Start()
    {
        _target = GameObject.FindObjectOfType<PlayerController>().gameObject;
    }

    private void Update()
    {
        transform.position = _target.transform.position;
    }
}
