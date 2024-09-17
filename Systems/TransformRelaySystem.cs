using System;
using ECS.Modules.Exerussus.Movement;
using Exerussus._1EasyEcs.Scripts.Core;
using Leopotam.EcsLite;

namespace ECS.Modules.Exerussus.TransformRelay.Systems
{
    public class TransformRelaySystem : EasySystem<TransformRelayPooler>
    {
        public TransformRelaySystem(TransformRelaySettings settings)
        {
            _settings = settings;
        }

        private TransformRelaySettings _settings;
        private EcsFilter _transformData;
        private MovementPooler _movementPooler;
        private Action<int> _updateAction;
        
        protected override void Initialize()
        {
            _transformData = World.Filter<TransformRelayData.Transform>().Inc<MovementData.Position>().End();
            GameShare.GetSharedObject(ref _movementPooler);
            if (_settings.IsPositionOrigin)
            {
                _updateAction = entity =>
                {
                    ref var positionData = ref _movementPooler.Position.Get(entity);
                    ref var transformRelayData = ref Pooler.Transform.Get(entity);
                    transformRelayData.Value.position = positionData.Value;
                };
            }
            else
            {
                _updateAction = entity =>
                {
                    ref var positionData = ref _movementPooler.Position.Get(entity);
                    ref var transformRelayData = ref Pooler.Transform.Get(entity);
                    positionData.Value = transformRelayData.Value.position;
                };
            }
        }

        protected override void Update()
        {
            foreach (var entity in _transformData) _updateAction.Invoke(entity);
        }
    }
}