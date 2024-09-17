
using ECS.Modules.Exerussus.TransformRelay.Systems;
using Exerussus._1EasyEcs.Scripts.Custom;
using Leopotam.EcsLite;

namespace ECS.Modules.Exerussus.TransformRelay
{
    public class TransformRelayGroup : EcsGroup<TransformRelayPooler>
    {
        public TransformRelaySettings Settings = new();
        
        protected override void SetFixedUpdateSystems(IEcsSystems fixedUpdateSystems)
        {
            fixedUpdateSystems.Add(new TransformRelaySystem(Settings));
        }
    }
}