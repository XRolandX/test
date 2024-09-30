using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Entities;
using Unity.Collections;
using Unity.Transforms;

public class UIHandler : MonoBehaviour
{
    [SerializeField] GameObject androidOverlay;
    private PlayerControls playerControls;
    public EntityManager entityManager;
    private void Awake()
    {

        #if PLATFORM_STANDALONE_WIN
        androidOverlay.SetActive(false);
        #endif

        #if UNITY_ANDROID
        androidOverlay.SetActive(true);
        #endif

        Cursor.lockState = CursorLockMode.Locked;
        playerControls = new PlayerControls();
        playerControls.Player.RestartScene.performed += ctx => RestartScene();
        playerControls.Player.ToMainMenu.performed += ctx => MainSceneLoading();
        
        #if UNITY_EDITOR
        playerControls.Player.StopPlayMode.performed += ctx => StopPlayMode();
        playerControls.Player.CursorUnlock.performed += ctx => CursorUnlocking();
        #endif

        entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
    }


    public void RestartScene()
    {
        DestroyAllEntities();
        SceneManager.LoadScene(3);
    }
    public void MainSceneLoading()
    {
        DestroyAllEntities();
        SceneManager.LoadScene(0);
    }

    #if UNITY_EDITOR
    void StopPlayMode()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    void CursorUnlocking()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    #endif

    void DestroyAllEntities()
    {
        EntityQuery query = entityManager.CreateEntityQuery(ComponentType.ReadOnly<LocalTransform>());
        NativeArray<Entity> entities = query.ToEntityArray(Allocator.TempJob);
        for (int i = 0; i < entities.Length; i++)
        {
            entityManager.DestroyEntity(entities[i]);
        }
        entities.Dispose();
    }
    private void OnEnable()
    {
        playerControls.Player.Enable();
    }
    private void OnDisable()
    {
        playerControls.Player.Disable();
    }

}
