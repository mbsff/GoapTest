using CrashKonijn.Agent.Core;
using CrashKonijn.Agent.Runtime;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

namespace Assets.Scripts.AI.GOAP.Behaviours
{
    public class NavMeshAgentMoveBehaviour : MonoBehaviour
    {
        private NavMeshAgent navMeshAgent;

        private AgentBehaviour agent;
        private ITarget currentTarget;

        private void Awake()
        {
            this.agent = this.GetComponent<AgentBehaviour>();
            navMeshAgent = this.GetComponent<NavMeshAgent>();
        }

        private void OnEnable()
        {
            this.agent.Events.OnTargetChanged += this.OnTargetChanged;
        }

        private void OnDisable()
        {
            this.agent.Events.OnTargetChanged -= this.OnTargetChanged;
        }

        private void OnTargetChanged(ITarget target, bool inRange)
        {
            this.currentTarget = target;
            navMeshAgent.SetDestination(target.Position);
        }

        private void OnDrawGizmos()
        {
            if (this.currentTarget == null)
                return;
            Gizmos.color = Color.red;
            Gizmos.DrawLine(this.transform.position, this.currentTarget.Position);
        }
    }
}