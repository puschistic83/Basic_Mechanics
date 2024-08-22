using UnityEngine;

namespace Code
{
    public class MoveByLerpObject : MonoBehaviour
    {
        public float Speed = 0.3f;
        public Transform StartPoint;
        public Transform EndPointPoint;
        public Transform Target;

        private void Start()
        {
            Target.position = StartPoint.position;
        }

        private void Update()
        {
            Target.position = Vector3.Lerp(Target.position, EndPointPoint.position, Speed * Time.deltaTime);
        }
    }
}
