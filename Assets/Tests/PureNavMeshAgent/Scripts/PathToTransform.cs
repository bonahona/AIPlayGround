using Shared;
using UnityEngine;
using UnityEngine.AI;

namespace Tests.PureNavMeshAgent {
    [RequireComponent(typeof(NavMeshAgent))]
    public class PathToTransform : MonoBehaviour
    {
        public ValueRange PriorityRange;
        public Transform TargetTransform;

        [Header("Components")]
        public NavMeshAgent Agent;

        private void Start()
        {
            if(TargetTransform == null ) {
                gameObject.SetActive(false);
            }

            Agent.avoidancePriority = PriorityRange.GetValue();
        }


        private void Update()
        {
            Agent.SetDestination(TargetTransform.position);
        }
    }
}