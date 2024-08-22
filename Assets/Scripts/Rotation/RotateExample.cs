using UnityEngine;

namespace Code
{
    public class RotateExample : MonoBehaviour
    {
        public Transform Target; 
        
       /* private void Start()
        {
            Vector3 pos = Target.position.normalized;
            float angle = Mathf.Acos(pos.z) * Mathf.Rad2Deg;
            Target.Rotate(Vector3.up, angle - Target.rotation.eulerAngles.y);

            Vector3 newRotation = new Vector3(0, 90, 0);
            Target.eulerAngles = newRotation;   // 1
            Target.rotation = Quaternion.Euler(newRotation);   // 2
        }*/
        
        
        private void RotationExampleThree()
        {
            transform.rotation = Quaternion.LookRotation(Target.position, Vector3.up);  // 1
            transform.LookAt(Target.position, Vector3.up); // 2
        }
        
        private void RotationExampleFour()
        {
            Vector3 direction = Target.position - transform.position;
            Quaternion toRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, 1);
        }
        
        private void RotationExampleFive()
        {
            Vector3 direction = Target.position - transform.position;
            Quaternion toRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 1);
        }
        private void Update()
        {
            RotationExampleThree();
        }
    }
}
