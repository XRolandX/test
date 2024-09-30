public class BlueBuilding : Building
{
    private readonly float maxRedWarehouseStorage = 5f;
    private readonly float maxGreenWarehouseStorage = 5f;

    protected override void InitializeBuilding()
    {
        resourceColor = "blue";
        resourceType = "Blue";
        resourceCountDisplay = ResourceManager.Instance.blueResources;
        produceTimeElapsed = productionResourceInterval;
        gettingTimeElapsed = gettingResourceInterval;
    }

    protected override void GetResource()
    {
        if (!isResourceInTransition) 
        {
            // ������������� ������� ����� ��� ����������� ������� � �������� � ��������� ������
            TransferResource(greenResStorePoint, ResourceManager.Instance.greenResources, ResourceManager.Instance.blueGreenWarehouse, maxGreenWarehouseStorage, this);
            TransferResource(redResStorePoint, ResourceManager.Instance.redResources, ResourceManager.Instance.blueRedWarehouse, maxRedWarehouseStorage, this);
        }
    }

    protected override void ProduceResource()
    {
        if (ResourceManager.Instance.blueGreenWarehouse.Count > 0 && ResourceManager.Instance.blueRedWarehouse.Count > 0 && ResourceManager.Instance.blueResources.Count < maxResourceCount)
        {
            // ������������� ������� ����� ��� �������� ������� � ���� ������
            DestroyResources(ResourceManager.Instance.blueGreenWarehouse, 1);
            DestroyResources(ResourceManager.Instance.blueRedWarehouse, 1);

            ResourceManager.Instance.ResourceInstance(ResourceManager.Instance.blueResourcePrefab, resSpawnPoint.transform, ResourceManager.Instance.blueResources);
        }
    }
}
