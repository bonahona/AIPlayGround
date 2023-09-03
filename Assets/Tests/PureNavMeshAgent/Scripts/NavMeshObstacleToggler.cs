using UnityEngine;
using UnityEngine.AI;

namespace Tests.PureNavMeshAgent {
    [RequireComponent(typeof(NavMeshAgent))]
    [RequireComponent (typeof(NavMeshObstacle))]
    public class NavMeshObstacleToggler : MonoBehaviour
    {
        [Header("Components")]
        public NavMeshAgent NavMeshAgent;
        public NavMeshObstacle NavMeshObstacle;

        private bool AgentActive = false;

        private void Start() {
            Toggle();
        }

        public void Toggle() {
            AgentActive = !AgentActive;

            if(AgentActive) {
                NavMeshAgent.enabled = true;
                NavMeshObstacle.enabled = false;
            } else {
                NavMeshAgent.enabled = false;
                NavMeshObstacle.enabled = true;
            }
        }
    }
}