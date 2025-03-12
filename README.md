This code is based on the Idle goap agent example. The differences are:
- IdleTargetSensor chooses a random spot 10m away from the agent
- IdleAction Timer reduced to 0,5-1s
- NavMeshAgentMoveBehaviour added to allow the agent to navigate using navmesh
- NavMeshDistanceObserver implemented as shown in https://goap.crashkonijn.com/classes/agentbehaviourandactionprovider#example 
	with an inspector toggle that allows you to switch back to Vector3.Distance calculation


In the unity hierarchy the important things are:
- Floor: contains the navmesh where the agent walks on
- Agent: contains the idle GOAP agent scripts, the following components are important:
	- Nav Mesh Distance observer: toggle for distance calculation
	- Nav Mesh Agent Move Behaviour and Agent Move Behaviour: disable one of them to either use NavMesh or Vector3.MoveTowards navigation like in the tutorial


The result of the race condition should be fairly easy to spot as the agent will choose a new target before reaching the current target,
you can also see it in the Agent Behaviour Logger Config where MoveState: InRange when Distance > Stopping distance