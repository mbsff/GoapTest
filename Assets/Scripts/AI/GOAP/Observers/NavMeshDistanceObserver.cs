using CrashKonijn.Agent.Core;
using CrashKonijn.Agent.Runtime;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.AI.GOAP.Observers
{
    public class NavMeshDistanceObserver : MonoBehaviour, IAgentDistanceObserver
    {
        private NavMeshAgent navMeshAgent;

        [SerializeField]
        private bool navMeshDistance = true;

        private void Awake()
        {
            this.navMeshAgent = this.GetComponent<NavMeshAgent>();
            this.GetComponent<AgentBehaviour>().DistanceObserver = this;
        }

        public float GetDistance(IMonoAgent agent, ITarget target, IComponentReference reference)
        {
            if (navMeshDistance)
            {
                var distance = this.navMeshAgent.remainingDistance;

                // No path
                if (float.IsInfinity(distance))
                    return 0f;

                return distance;
            }
            else
            {
                if (target != null)
                {
                    return Vector3.Distance(agent.Transform.position, target.Position);
                }
                return 0f;
            }
        }
    }
}
