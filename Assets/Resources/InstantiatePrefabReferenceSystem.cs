using Unity.Collections;
using Unity.Entities;
using Unity.Scenes;
using Unity.Transforms;

public partial struct InstantiatePrefabReferenceSystem : ISystem
{
    public void OnStartRunning(ref SystemState state)
    {
        var query = SystemAPI.QueryBuilder()
            .WithAll<EntityPrefabReferenceComponent>()
            .WithNone<PrefabLoadResult>().Build();
        state.EntityManager.AddComponent<RequestEntityPrefabLoaded>(query);
    }

    public void OnUpdate(ref SystemState state)
    {
        var mouseInput = SystemAPI.GetSingleton<MouseInput>();
        var spawnPosition = SystemAPI.GetSingleton<SpawnPosition>().Position;
        var spawnRotation = SystemAPI.GetSingleton<SpawnRotation>().Rotation;
        var localTransform = LocalTransform.FromPositionRotation(spawnPosition, spawnRotation);

        var ecb = new EntityCommandBuffer(Allocator.Temp);

        foreach (var (prefab, entity) in
                 SystemAPI.Query<RefRO<PrefabLoadResult>>().WithEntityAccess())
        {
            var instance = ecb.Instantiate(prefab.ValueRO.PrefabRoot);

            ecb.AddComponent(instance, localTransform);



            ecb.RemoveComponent<RequestEntityPrefabLoaded>(entity);
            ecb.RemoveComponent<PrefabLoadResult>(entity);
        }

        ecb.Playback(state.EntityManager);
        ecb.Dispose();
    }
}