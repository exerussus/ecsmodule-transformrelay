
using ECS.Modules.Exerussus.TransformRelay.Systems;
using Exerussus._1EasyEcs.Scripts.Core;
using Exerussus._1EasyEcs.Scripts.Custom;
using Exerussus._1Extensions.SmallFeatures;
using Leopotam.EcsLite;

namespace ECS.Modules.Exerussus.TransformRelay
{
    public class TransformRelayGroup : EcsGroup<TransformRelayPooler>
    {
        private TransformRelaySettings Settings = new();
        
        protected override void SetFixedUpdateSystems(IEcsSystems fixedUpdateSystems)
        {
            if (Settings.Update == UpdateType.FixedUpdate) fixedUpdateSystems.Add(new TransformRelaySystem());
        }

        protected override void SetUpdateSystems(IEcsSystems updateSystems)
        {
            if (Settings.Update == UpdateType.Update) updateSystems.Add(new TransformRelaySystem());
        }

        protected override void SetSharingData(EcsWorld world, GameShare gameShare)
        {
            gameShare.AddSharedObject(Settings);
        }

        public TransformRelayGroup SetUpdateType(UpdateType updateType)
        {
            Settings.Update = updateType;
            return this;
        }
        
        public TransformRelayGroup SetPositionOriginMode(bool isEnabled)
        {
            Settings.IsPositionOrigin = isEnabled;
            return this;
        }
    }
}