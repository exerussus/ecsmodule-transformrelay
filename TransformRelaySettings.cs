using Exerussus._1EasyEcs.Scripts.Core;

namespace ECS.Modules.Exerussus.TransformRelay
{
    public class TransformRelaySettings
    {
        /// <summary> В каком апдейте производится работа. </summary>
        public UpdateType Update = UpdateType.FixedUpdate;
        /// <summary>
        /// Если включено - transform получает значения Position, в противном случае
        /// Position будет приравниваться к Transform.
        /// </summary>
        public bool IsPositionOrigin = true;
    }
}