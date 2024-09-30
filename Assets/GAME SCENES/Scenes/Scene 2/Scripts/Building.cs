using UnityEngine;
using TMPro;
using System.Collections.Generic;

public abstract class Building : MonoBehaviour
{
    [SerializeField] protected float productionResourceInterval;
    [SerializeField] protected float gettingResourceInterval;
    private const float DefaultMaxResourceCount = 5.0f;
    [SerializeField] protected float maxResourceCount = DefaultMaxResourceCount;

    protected float produceTimeElapsed;
    protected float gettingTimeElapsed;

    protected string resourceColor;
    protected string resourceType;
    protected List<GameObject> resourceCountDisplay;
    [SerializeField] protected TextMeshPro resourceDisplay;

    [SerializeField] protected Transform resSpawnPoint;
    [SerializeField] protected Transform redResStorePoint;
    [SerializeField] protected Transform greenResStorePoint;

    public bool isResourceInTransition = false;

    protected virtual void Start()
    {
        InitializeBuilding();
    }
    protected virtual void Update()
    {
        ProduceTimeElapse();
        ResourceDisplay();
        GetResourceTimeElapse();
    }
    
    private void ProduceTimeElapse()
    {
        produceTimeElapsed -= Time.deltaTime;

        if (produceTimeElapsed <= 0)
        {
            ProduceResource();
            produceTimeElapsed += productionResourceInterval;
        }
    }

    private void GetResourceTimeElapse()
    {
        gettingTimeElapsed -= Time.deltaTime;

        if (gettingTimeElapsed <= 0)
        {
            GetResource();
            gettingTimeElapsed += gettingResourceInterval;
        }
    }

    protected virtual void ResourceDisplay()
    {
        if (resourceDisplay != null)
        {
            resourceDisplay.text = "<color=" + resourceColor + ">" + resourceType + "</color> resource: "
                + resourceCountDisplay.Count.ToString("F0")
                + "\nProduction time: " + produceTimeElapsed.ToString("F3")
                + "\nGetting time: " + gettingTimeElapsed.ToString("F3");
        }
        else
        {
            Debug.LogError("Resource Index TMP is not set in Inspector on some Building");
        }
    }

    // ������ ����� ��� ��������� �������
    protected void TransferResource(Transform storePoint, List<GameObject> fromWarehouse, List<GameObject> toWarehouse, float maxWarehouseCapacity, Building building)
    {
        if (toWarehouse.Count < maxWarehouseCapacity && fromWarehouse.Count > 0)
        {
            ResourceManager.Instance.GetLatestResource(storePoint, fromWarehouse, toWarehouse, building);
            building.isResourceInTransition = true;
        }
    }

    // ������ ����� ��� �������� �������
    protected void DestroyResources(List<GameObject> warehouse, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            if (warehouse.Count > 0)
            {
                Destroy(warehouse[^1]);
                warehouse.RemoveAt(warehouse.Count - 1);
            }
        }
    }

    protected abstract void InitializeBuilding();
    protected abstract void ProduceResource();
    protected abstract void GetResource();
}
