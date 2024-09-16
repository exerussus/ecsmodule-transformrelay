
using Exerussus._1EasyEcs.Scripts.Core;
using Exerussus._1EasyEcs.Scripts.Custom;
using Leopotam.EcsLite;

namespace ECS.Modules.Exerussus.TransformRelay
{
    public class TransformRelayPooler : IGroupPooler
    {
        public void Initialize(EcsWorld world)
        {
            Transform = new PoolerModule<TransformRelayData.Transform>(world);
        }

        public PoolerModule<TransformRelayData.Transform> Transform { get; private set; }
    }
}