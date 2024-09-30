//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.1
//     from Assets/GAME SCENES/Scenes/Scene 3/Input System/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""d46aa6a8-8f0f-43ec-b490-b185d1210180"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ab909498-8701-4263-bd39-ffa08d616dfb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""74773236-7a62-423c-a1d0-01b41ef8b9ae"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Mouse Click"",
                    ""type"": ""Button"",
                    ""id"": ""9550681e-28f8-4611-b0ad-4a75c2f907b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Right Mouse Click"",
                    ""type"": ""Button"",
                    ""id"": ""b4c6c70d-5239-4fc7-8a3b-617ab16b9272"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Restart Scene"",
                    ""type"": ""Button"",
                    ""id"": ""57911bdd-a0ce-47f1-9ef3-2b49037ea28a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""To Main Menu"",
                    ""type"": ""Button"",
                    ""id"": ""9a0df188-d76d-4165-8882-304225663c37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""da6ab380-340d-4749-a5e4-c0b749dc7b63"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Stop Play Mode"",
                    ""type"": ""Button"",
                    ""id"": ""37b1f81a-327c-4b08-896d-6ce8ae055dda"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cursor Unlock"",
                    ""type"": ""Button"",
                    ""id"": ""bb00ef9c-df92-4f83-a4dc-f41abae81099"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""783b8a6f-198b-44cb-86f4-18a0c88b0c28"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3d0f8380-2fd8-443b-801d-e2fe0a87ba10"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""acc53e21-bd6d-424d-85ee-892a7da89818"",
                    ""path"": ""<Keyboard>/#(W)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""710fb276-76b1-44d2-bcd6-2e811c5fc037"",
                    ""path"": ""<Keyboard>/#(S)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""67429379-9f6d-43c9-aeef-32fa663eca1f"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7a3ff805-5b11-4507-9f02-58dc3a4739ef"",
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""014f39c1-ab8c-4d00-8d24-646b674bf898"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""301439fc-d893-4c85-954c-4f01522c613e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Mouse Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e535db9-8f31-42ac-817b-4b7b6bd271e1"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart Scene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5c52dbf-ecec-4bb3-9684-14109f6252a6"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""To Main Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89da3bcb-0793-4057-9a59-595bc56ff741"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2434227e-676d-4add-8ea7-a046c8e33713"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stop Play Mode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""331c3855-2727-4b5a-af4f-693f64d61017"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cursor Unlock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_MouseClick = m_Player.FindAction("Mouse Click", throwIfNotFound: true);
        m_Player_RightMouseClick = m_Player.FindAction("Right Mouse Click", throwIfNotFound: true);
        m_Player_RestartScene = m_Player.FindAction("Restart Scene", throwIfNotFound: true);
        m_Player_ToMainMenu = m_Player.FindAction("To Main Menu", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_StopPlayMode = m_Player.FindAction("Stop Play Mode", throwIfNotFound: true);
        m_Player_CursorUnlock = m_Player.FindAction("Cursor Unlock", throwIfNotFound: true);
    }

    ~@PlayerControls()
    {
        UnityEngine.Debug.Assert(!m_Player.enabled, "This will cause a leak and performance issues, PlayerControls.Player.Disable() has not been called.");
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_MouseClick;
    private readonly InputAction m_Player_RightMouseClick;
    private readonly InputAction m_Player_RestartScene;
    private readonly InputAction m_Player_ToMainMenu;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_StopPlayMode;
    private readonly InputAction m_Player_CursorUnlock;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @MouseClick => m_Wrapper.m_Player_MouseClick;
        public InputAction @RightMouseClick => m_Wrapper.m_Player_RightMouseClick;
        public InputAction @RestartScene => m_Wrapper.m_Player_RestartScene;
        public InputAction @ToMainMenu => m_Wrapper.m_Player_ToMainMenu;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @StopPlayMode => m_Wrapper.m_Player_StopPlayMode;
        public InputAction @CursorUnlock => m_Wrapper.m_Player_CursorUnlock;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @MouseClick.started += instance.OnMouseClick;
            @MouseClick.performed += instance.OnMouseClick;
            @MouseClick.canceled += instance.OnMouseClick;
            @RightMouseClick.started += instance.OnRightMouseClick;
            @RightMouseClick.performed += instance.OnRightMouseClick;
            @RightMouseClick.canceled += instance.OnRightMouseClick;
            @RestartScene.started += instance.OnRestartScene;
            @RestartScene.performed += instance.OnRestartScene;
            @RestartScene.canceled += instance.OnRestartScene;
            @ToMainMenu.started += instance.OnToMainMenu;
            @ToMainMenu.performed += instance.OnToMainMenu;
            @ToMainMenu.canceled += instance.OnToMainMenu;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @StopPlayMode.started += instance.OnStopPlayMode;
            @StopPlayMode.performed += instance.OnStopPlayMode;
            @StopPlayMode.canceled += instance.OnStopPlayMode;
            @CursorUnlock.started += instance.OnCursorUnlock;
            @CursorUnlock.performed += instance.OnCursorUnlock;
            @CursorUnlock.canceled += instance.OnCursorUnlock;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @MouseClick.started -= instance.OnMouseClick;
            @MouseClick.performed -= instance.OnMouseClick;
            @MouseClick.canceled -= instance.OnMouseClick;
            @RightMouseClick.started -= instance.OnRightMouseClick;
            @RightMouseClick.performed -= instance.OnRightMouseClick;
            @RightMouseClick.canceled -= instance.OnRightMouseClick;
            @RestartScene.started -= instance.OnRestartScene;
            @RestartScene.performed -= instance.OnRestartScene;
            @RestartScene.canceled -= instance.OnRestartScene;
            @ToMainMenu.started -= instance.OnToMainMenu;
            @ToMainMenu.performed -= instance.OnToMainMenu;
            @ToMainMenu.canceled -= instance.OnToMainMenu;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @StopPlayMode.started -= instance.OnStopPlayMode;
            @StopPlayMode.performed -= instance.OnStopPlayMode;
            @StopPlayMode.canceled -= instance.OnStopPlayMode;
            @CursorUnlock.started -= instance.OnCursorUnlock;
            @CursorUnlock.performed -= instance.OnCursorUnlock;
            @CursorUnlock.canceled -= instance.OnCursorUnlock;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnMouseClick(InputAction.CallbackContext context);
        void OnRightMouseClick(InputAction.CallbackContext context);
        void OnRestartScene(InputAction.CallbackContext context);
        void OnToMainMenu(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnStopPlayMode(InputAction.CallbackContext context);
        void OnCursorUnlock(InputAction.CallbackContext context);
    }
}
