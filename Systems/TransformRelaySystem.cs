using ECS.Modules.Exerussus.Movement;
using Exerussus._1EasyEcs.Scripts.Core;
using Leopotam.EcsLite;

namespace ECS.Modules.Exerussus.TransformRelay.Systems
{
    public class TransformRelaySystem : EasySystem<TransformRelayPooler>
    {
        private EcsFilter _transformData;
        private MovementPooler _movementPooler;
        
        protected override void Initialize()
        {
            _transformData = World.Filter<TransformRelayData.Transform>().Inc<MovementData.Position>().End();
            GameShare.GetSharedObject(ref _movementPooler);
        }

        protected override void Update()
        {
            foreach (var entity in _transformData)
            {
                ref var positionData = ref _movementPooler.Position.Get(entity);
                ref var transformRelayData = ref Pooler.Transform.Get(entity);
                transformRelayData.Value.position = positionData.Value;
            }
        }
    }
}