using Unity.Entities;
using Unity.Physics;
using UnityEngine;
using Unity.Mathematics;
using Unity.Transforms;
using Unity.Collections;

public partial class SpawnEntities : SystemBase
{
    private EndSimulationEntityCommandBufferSystem _ecbSystem;
    private Entity _prefabEntity;
    private float spawnTimer = 0f;
    private readonly float entityForce = 100f;

    protected override void OnCreate()
    {
        //_ecbSystem = World.GetOrCreateSystemManaged<EndSimulationEntityCommandBufferSystem>();


        //var projectilePrefab = new EntityQueryBuilder(Allocator.Temp).WithAll<Prefab>().Build(EntityManager);

        //if (projectilePrefab.IsEmpty)
        //{
        //    Debug.LogError("Prefab Entity not found in Subscene!");
        //}
        //else
        //{
        //    // Завантажуємо перший знайдений префаб
        //    _prefabEntity = projectilePrefab.GetSingletonEntity();
        //}
    }

    protected override void OnUpdate()
    {
        CreateEntitiesByClick();
    }
    public void CreateEntitiesByClick()
    {
        var deltaTime = SystemAPI.Time.DeltaTime;
        spawnTimer += deltaTime;

        var mouseInput = SystemAPI.GetSingleton<MouseInput>();
        var spawnPosition = SystemAPI.GetSingleton<SpawnPosition>().Position;
        var spawnRotation = SystemAPI.GetSingleton<SpawnRotation>().Rotation;
        var localTransform = LocalTransform.FromPositionRotation(spawnPosition, spawnRotation);

        if (mouseInput.LeftClickPerformed && spawnTimer >= 0.1f)
        {
            spawnTimer = 0f;
            var ecb = _ecbSystem.CreateCommandBuffer();

            if (_prefabEntity != Entity.Null)
            {
                float3 forwardDirection = math.mul(spawnRotation, new float3(0, 0, 1));
                Entity instance = ecb.Instantiate(_prefabEntity);

                ecb.SetComponent(instance, localTransform);
                ecb.AddComponent(instance, new PhysicsVelocity
                {
                    Linear = forwardDirection * entityForce,
                    Angular = float3.zero
                });

                _ecbSystem.AddJobHandleForProducer(Dependency);
            }
            else
            {
                Debug.LogError("Cube prefab is null");
            }
        }
    }
}