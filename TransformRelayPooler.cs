
using ECS.Modules.Exerussus.Movement;
using Exerussus._1EasyEcs.Scripts.Core;
using Exerussus._1EasyEcs.Scripts.Custom;
using Leopotam.EcsLite;
using UnityEngine;

namespace ECS.Modules.Exerussus.TransformRelay
{
    public class TransformRelayPooler : IGroupPooler
    {
        public void Initialize(EcsWorld world)
        {
            Transform = new PoolerModule<TransformRelayData.Transform>(world);
        }

        [InjectSharedObject] private MovementPooler _movementPooler;
        public PoolerModule<TransformRelayData.Transform> Transform { get; private set; }

        public void CreateBaseData(int entity, Transform transform)
        {
            ref var positionData = ref _movementPooler.Position.Add(entity);
            positionData.Value = transform.position;
            ref var transformRelayData = ref Transform.Add(entity);
            transformRelayData.Value = transform;
        }
    }
}