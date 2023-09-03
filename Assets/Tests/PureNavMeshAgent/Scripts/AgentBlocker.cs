using Shared;
using UnityEngine;
using UnityEngine.AI;

namespace Tests.PureNavMeshAgent {
    [RequireComponent(typeof(NavMeshAgent))]

    public class AgentBlocker : MonoBehaviour
    {
        public ValueRange PriorityRange;

        [Header("Components")]
        public NavMeshAgent Agent;

        private void Start() {
            Agent.avoidancePriority = PriorityRange.GetValue();
        }
    }
}