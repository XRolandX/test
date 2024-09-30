using Unity.Entities.Serialization;
using Unity.Entities;

public class GetPrefabReferenceBaker : Baker<GetPrefabReferenceAuthoring>
{
    public override void Bake(GetPrefabReferenceAuthoring authoring)
    {
        // Create an EntityPrefabReference from a GameObject. This will allow the
        // serialization process to serialize the prefab in its own entity scene
        // file instead of duplicating the prefab ECS content everywhere it is used
        var entityPrefab = new EntityPrefabReference(authoring.Prefab);
        var entity = GetEntity(TransformUsageFlags.Dynamic);
        AddComponent(entity, new EntityPrefabReferenceComponent() { Value = entityPrefab });
    }
}