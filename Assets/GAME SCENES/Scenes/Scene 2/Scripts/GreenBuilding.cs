public class GreenBuilding : Building
{
    private readonly float maxRedWarehouseStorage = 5f;

    protected override void InitializeBuilding()
    {
        resourceColor = "green";
        resourceType = "Green";
        resourceCountDisplay = ResourceManager.Instance.greenResources;
        produceTimeElapsed = productionResourceInterval;
        gettingTimeElapsed = gettingResourceInterval;
    }

    protected override void GetResource()
    {
        if (!isResourceInTransition) 
        {
            // ������������� ������� ����� ��� ����������� �������
            TransferResource(redResStorePoint, ResourceManager.Instance.redResources, ResourceManager.Instance.greenRedWarehouse, maxRedWarehouseStorage, this);
        }
        
    }

    protected override void ProduceResource()
    {
        if (ResourceManager.Instance.greenResources.Count < maxResourceCount && ResourceManager.Instance.greenRedWarehouse.Count > 0)
        {
            // ������������� ������� ����� ��� �������� ������ �������
            DestroyResources(ResourceManager.Instance.greenRedWarehouse, 1);
            ResourceManager.Instance.ResourceInstance(ResourceManager.Instance.greenResourcePrefab, resSpawnPoint.transform, ResourceManager.Instance.greenResources);
        }
    }
}
