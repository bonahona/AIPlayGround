using UnityEngine;
using UnityEngine.AI;

namespace Tests.Boids {
    [RequireComponent(typeof(NavMeshAgent))]
    public class Boid : MonoBehaviour
    {
        public BoidController Controller;

        [Header("Components")]
        public NavMeshAgent Agent;

        private void Update()
        {
            Agent.SetDestination(Controller.transform.position);
        }

        public void SetColor(Color color) {
            foreach(var renderer in GetComponentsInChildren<Renderer>()) {
                renderer.material.color = color;
            }
        }
    }
}