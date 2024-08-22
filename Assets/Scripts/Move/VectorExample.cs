using UnityEngine;

namespace Code
{
    public class VectorExample : MonoBehaviour
    {
        public float Dot;
        public Transform TargetFirst;
        public Transform TargetSecond;
        public float Speed = 3.0f;
        
        private void Start()
        {
            Vector2 vector2 = new Vector2(1, 2);
            Vector3 vector3 = new Vector3(1, 2, 3);
            Vector4 vector4 = new Vector4(1, 2, 3, 4);
            Vector2Int vector2Int = new Vector2Int(1, 2);
            Vector3Int vector3Int = new Vector3Int(1, 2, 3);
            
            Example();
        }

        private void Example()
        {
            Vector3 firstPosition = TargetFirst.position;
            Vector3 secondPosition = TargetSecond.position;

            Transform primitive = GameObject.CreatePrimitive(PrimitiveType.Cube).transform;
            primitive.position = firstPosition + secondPosition;
            primitive.position *= 5.0f;
            
          //  primitive.transform.position = Vector3.Cross(firstPosition, secondPosition);
            //https://docs.unity3d.com/ru/2019.4/Manual/UnderstandingVectorArithmetic.html
           // primitive.transform.position = Vector3.Reflect(firstPosition, Vector3.forward);
            //https://docs.unity3d.com/ScriptReference/Vector3.Reflect.html
        }
        
        private void Update()
        {
            Move();
            return; 
            Dot = Vector3.Dot(TargetFirst.forward, TargetSecond.position);
        }

        private void Move()
        {
            float directionVertical = 0.0f;
            float directionHorizontal = 0.0f;
            
            if (Input.GetKey(KeyCode.W))
            {
                directionVertical = 1.0f;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                directionVertical = -1.0f;
            }

            if (Input.GetKey(KeyCode.A))
            {
                directionHorizontal = -1.0f;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                directionHorizontal = 1.0f;
            }

            Vector3 targetFirstVertical = TargetFirst.forward * directionVertical;
            Vector3 targetFirstHorizontal = TargetFirst.right * directionHorizontal;

            TargetFirst.position += (targetFirstVertical + targetFirstHorizontal) * Speed * Time.deltaTime;
        }
        
        private void DistanceTest()
        {
            float distance = Vector3.Distance(TargetFirst.position, TargetSecond.position);
            if(distance > 5)
            {
                Debug.Log("Close!");
            }
        }

        private void AngleTest()
        {
            if(Vector3.Angle(TargetFirst.forward, TargetFirst.position - TargetSecond.position) <= 30)
            {
                Debug.Log("Visible!");
            }
        }

        private void RotationExampleSix()
        {
            Vector2.Perpendicular(transform.position);
        }
    }
}
