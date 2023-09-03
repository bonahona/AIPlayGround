using Shared;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

namespace Tests.PureNavMeshAgent {
    [RequireComponent(typeof(NavMeshAgent))]
    public class PathToTransform : MonoBehaviour
    {
        public ValueRange PriorityRange;
        public NavMeshObstacle TargetAgent;

        [Header("Components")]
        public NavMeshAgent Agent;

        private void Start()
        {
            if(TargetAgent == null ) {
                gameObject.SetActive(false);
            }

            Agent.avoidancePriority = PriorityRange.GetValue();
        }


        private void Update()
        {
            if(DestinationReached()) {
                return;
            }

            Agent.SetDestination(TargetAgent.transform.position - GetOffset());
        }

        private bool DestinationReached() => (Agent.transform.position - Agent.pathEndPosition).sqrMagnitude < 0.0001f;
        private Vector3 GetOffset() => (TargetAgent.transform.position - Agent.transform.position).normalized * (TargetAgent.radius + Agent.radius);
    }
}