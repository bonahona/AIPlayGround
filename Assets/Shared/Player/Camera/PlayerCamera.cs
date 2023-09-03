using UnityEngine;

namespace Shared.Player {
    [RequireComponent(typeof(Camera))]
    public class PlayerCamera : MonoBehaviour
    {
        public Vector3 TargetRotation;
        public float Distance = 10;

        private void Start()
        {
            transform.localRotation = Quaternion.Euler(TargetRotation);
            transform.localPosition = transform.localRotation * Vector3.back * Distance;
        }
    }
}