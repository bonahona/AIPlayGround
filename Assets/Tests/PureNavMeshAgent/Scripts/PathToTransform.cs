using Shared;
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
            Agent.SetDestination(TargetAgent.transform.position - GetOffset());
        }

        private Vector3 GetOffset() => (TargetAgent.transform.position - Agent.transform.position).normalized * (TargetAgent.radius + Agent.radius);
    }
}