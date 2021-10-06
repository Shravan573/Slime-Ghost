// GENERATED AUTOMATICALLY FROM 'Assets/scripts/Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""PlayerMain"",
            ""id"": ""865379f6-4f97-4a2f-b314-a17e0f064121"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""12eb55cf-f634-4d00-a82a-c8330de72f05"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""3bad2188-df83-422a-865e-37f2ebd788cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""look"",
                    ""type"": ""Value"",
                    ""id"": ""d40fa26e-8e7e-4069-a681-b41efe17d6e8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToggleDebug"",
                    ""type"": ""Button"",
                    ""id"": ""94ebdcbd-2a7a-45f6-aabf-7f356c45d38b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""return"",
                    ""type"": ""Button"",
                    ""id"": ""a5fc1775-06fc-4821-9f6f-da8789241d16"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""26598a07-8420-4b3e-854c-7b7e214a204a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87ffd80f-e285-47b2-acc2-f2ec504f3005"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93158368-c680-408d-905c-1c3edb5ce278"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93f91119-38ce-4be3-ae6b-90f010d2c9b5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c2c61de-4c4b-4c51-8eb9-fbf474aee5fd"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8af97c52-80a9-419f-a22f-bdfb18cde44e"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""return"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMain
        m_PlayerMain = asset.FindActionMap("PlayerMain", throwIfNotFound: true);
        m_PlayerMain_move = m_PlayerMain.FindAction("move", throwIfNotFound: true);
        m_PlayerMain_jump = m_PlayerMain.FindAction("jump", throwIfNotFound: true);
        m_PlayerMain_look = m_PlayerMain.FindAction("look", throwIfNotFound: true);
        m_PlayerMain_ToggleDebug = m_PlayerMain.FindAction("ToggleDebug", throwIfNotFound: true);
        m_PlayerMain_return = m_PlayerMain.FindAction("return", throwIfNotFound: true);
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

    // PlayerMain
    private readonly InputActionMap m_PlayerMain;
    private IPlayerMainActions m_PlayerMainActionsCallbackInterface;
    private readonly InputAction m_PlayerMain_move;
    private readonly InputAction m_PlayerMain_jump;
    private readonly InputAction m_PlayerMain_look;
    private readonly InputAction m_PlayerMain_ToggleDebug;
    private readonly InputAction m_PlayerMain_return;
    public struct PlayerMainActions
    {
        private @Player m_Wrapper;
        public PlayerMainActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_PlayerMain_move;
        public InputAction @jump => m_Wrapper.m_PlayerMain_jump;
        public InputAction @look => m_Wrapper.m_PlayerMain_look;
        public InputAction @ToggleDebug => m_Wrapper.m_PlayerMain_ToggleDebug;
        public InputAction @return => m_Wrapper.m_PlayerMain_return;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMainActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMainActions instance)
        {
            if (m_Wrapper.m_PlayerMainActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @jump.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @look.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @look.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @look.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @ToggleDebug.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnToggleDebug;
                @ToggleDebug.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnToggleDebug;
                @ToggleDebug.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnToggleDebug;
                @return.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnReturn;
                @return.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnReturn;
                @return.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnReturn;
            }
            m_Wrapper.m_PlayerMainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @look.started += instance.OnLook;
                @look.performed += instance.OnLook;
                @look.canceled += instance.OnLook;
                @ToggleDebug.started += instance.OnToggleDebug;
                @ToggleDebug.performed += instance.OnToggleDebug;
                @ToggleDebug.canceled += instance.OnToggleDebug;
                @return.started += instance.OnReturn;
                @return.performed += instance.OnReturn;
                @return.canceled += instance.OnReturn;
            }
        }
    }
    public PlayerMainActions @PlayerMain => new PlayerMainActions(this);
    public interface IPlayerMainActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnToggleDebug(InputAction.CallbackContext context);
        void OnReturn(InputAction.CallbackContext context);
    }
}
