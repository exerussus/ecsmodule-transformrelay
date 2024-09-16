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

Зависимости:  
[Ecs-Lite](https://github.com/Leopotam/ecslite.git)  
[1EasyEcs](https://github.com/exerussus/1EasyEcs.git)   


Модули для подключения:  
[Movement](https://github.com/exerussus/ecsmodule-movement.git) 