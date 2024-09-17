Модуль для 1EasyEcs.   
Синхронизирует позицию трансформа с MovementData.Position.  

````csharp
        # При подключении в EcsStarter
        protected override EcsGroup[] GetGroups()
        {
            return new EcsGroup[]
            {
                # Необходимо устанавливать после MovementGroup.
                # Опционально можно выбрать режим апдейта.
                new MovementGroup { Settings = new MovementSettings { Update = UpdateType.Update }},
                new TransformRelayGroup { Settings = new TransformRelaySettings { Update = UpdateType.Update }}, 
            };
        }
````

Доступные настройки:

````csharp
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
````
Зависимости:  
[Ecs-Lite](https://github.com/Leopotam/ecslite.git)  
[1EasyEcs](https://github.com/exerussus/1EasyEcs.git)   


Модули для подключения:  
[Movement](https://github.com/exerussus/ecsmodule-movement.git) 