using Assets.Scripts.AI.GOAP.Capabilities;
using CrashKonijn.Goap.Core;
using CrashKonijn.Goap.Runtime;

namespace Assets.Scripts.AI.GOAP.AgentTypes
{
    public class DemoAgentTypeFactory : AgentTypeFactoryBase
    {
        public override IAgentTypeConfig Create()
        {
            var factory = new AgentTypeBuilder("ScriptDemoAgent");

            factory.AddCapability<IdleCapabilityFactory>();

            return factory.Build();
        }
    }
}