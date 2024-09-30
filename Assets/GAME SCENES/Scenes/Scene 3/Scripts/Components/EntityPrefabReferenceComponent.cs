using Unity.Entities.Serialization;
using Unity.Entities;

public struct EntityPrefabReferenceComponent : IComponentData
{
    public EntityPrefabReference Value;
}