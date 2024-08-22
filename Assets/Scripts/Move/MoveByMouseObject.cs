using UnityEngine;

namespace Code
{
    public class MoveByMouseObject : MonoBehaviour
    {
        public Transform Target;
        public Camera Camera;
        public float speed = 5.0f;

        private void Update()
        {
            Vector3 screenToWorldPoint = Camera.ScreenToWorldPoint(Input.mousePosition + Vector3.forward);

           // screenToWorldPoint.x = screenToWorldPoint.x;

          //  screenToWorldPoint.x = Mathf.Ceil(screenToWorldPoint.x);
          //  screenToWorldPoint.y = Mathf.Round(screenToWorldPoint.y);
            Target.position = new Vector3(screenToWorldPoint.x * speed, screenToWorldPoint.y * speed, Target.position.z);
           // https://docs.unity3d.com/ScriptReference/Mathf.Round.html
        }
    }
}
