using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Tests.Boids {

    [RequireComponent(typeof(NavMeshAgent))]
    public class BoidController : MonoBehaviour
    {
        public List<Transform> WayPoints = new List<Transform>();
        public float TargetTreshold = 0.1f;

        public Boid BoidPrefab;
        public int BoidCount;
        public Color BoidColor = Color.white;

        [Header("Components")]
        public NavMeshAgent Agent;

        private int CurrentTargetTransformIndex;

        private void Start() {
            SpawnBoids();
        }

        private void Update()
        {
            if(WayPoints.Count == 0) {
                return;
            }

            Agent.SetDestination(WayPoints[CurrentTargetTransformIndex].position);

            if(TargetReached()) {
                CurrentTargetTransformIndex = NextTargetIndex();
            }
        }

        private void SpawnBoids() {
            for(int i = 0; i < BoidCount; i++) {
                var boid = GameObject.Instantiate(BoidPrefab, transform.position + RandomOffset(), transform.rotation);
                boid.SetColor(BoidColor);
                boid.Controller = this;
            }
        }

        private Vector3 RandomOffset() => new Vector3(Random.Range(0f, 1f), 0f, Random.Range(0f, 1f)).normalized;

        private bool TargetReached() => (WayPoints[CurrentTargetTransformIndex].transform.position - transform.position).sqrMagnitude < (TargetTreshold * TargetTreshold); 

        private int NextTargetIndex() => (CurrentTargetTransformIndex +1) % WayPoints.Count;
    }
}