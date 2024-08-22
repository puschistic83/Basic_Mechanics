using UnityEngine;

namespace Code
{
    public class MoveByRepeatObject : MonoBehaviour
    {
        private void Update()
        {
            float x = Mathf.PingPong(Time.time, 3.0f);
            float y = Mathf.Repeat(Time.time, 3.0f);

            //transform.position.x = x;
            transform.position = new Vector3(x, y, transform.position.z);
        }
    }
}
