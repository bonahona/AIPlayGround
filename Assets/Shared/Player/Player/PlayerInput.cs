using UnityEngine;

namespace Shared.Player {
    public class PlayerInput : MonoBehaviour
    {
        public float Speed = 5;

        private void Start()
        {
        
        }

        private void FixedUpdate()
        {
            var inputDirection = GetInputDirection();

            transform.position += inputDirection * Time.fixedDeltaTime * Speed;
        }

        private Vector3 GetInputDirection() {
            var result = Vector3.zero;

            if(Input.GetKey(KeyCode.W)) {
                result.z = 1;
            } else if(Input.GetKey(KeyCode.S)) {
                result.z = -1;
            }

             if(Input.GetKey(KeyCode.A)) {
                result.x = -1;
            } else if(Input.GetKey(KeyCode.D)) {
                result.x = 1;
            }

             return result.normalized;
        }
    }
}