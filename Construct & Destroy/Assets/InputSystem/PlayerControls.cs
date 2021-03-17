// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""gameplay"",
            ""id"": ""0450f03e-47a0-4eb8-8122-e0ef965a63be"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""7403fe7f-9d7a-4268-9608-32c443aca74f"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""86ebe94e-9cb8-4175-8843-fbe3ecb90ed6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shootBullet"",
                    ""type"": ""Button"",
                    ""id"": ""963a4934-adff-46e0-a78b-604ad0a80737"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""laserWirbel"",
                    ""type"": ""Button"",
                    ""id"": ""f35655e5-67f4-43cb-b993-580c1f48f7a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rocket"",
                    ""type"": ""Button"",
                    ""id"": ""56f2c96b-76d1-4393-90b2-39ecd59d1e57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1c5d0c4b-43e8-4a48-8d71-9336f2314345"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3144a6ef-a766-49c6-a013-bc383b101da7"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e37712a7-da08-40ad-a3a7-b9f487c3966d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""laserWirbel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c86e804b-8cd7-4ace-a942-5a09336c2dba"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rocket"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d1074d5-a0af-4045-9b0c-6afac64ba5fc"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""shootBullet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // gameplay
        m_gameplay = asset.FindActionMap("gameplay", throwIfNotFound: true);
        m_gameplay_Walk = m_gameplay.FindAction("Walk", throwIfNotFound: true);
        m_gameplay_Rotate = m_gameplay.FindAction("Rotate", throwIfNotFound: true);
        m_gameplay_shootBullet = m_gameplay.FindAction("shootBullet", throwIfNotFound: true);
        m_gameplay_laserWirbel = m_gameplay.FindAction("laserWirbel", throwIfNotFound: true);
        m_gameplay_Rocket = m_gameplay.FindAction("Rocket", throwIfNotFound: true);
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

    // gameplay
    private readonly InputActionMap m_gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_gameplay_Walk;
    private readonly InputAction m_gameplay_Rotate;
    private readonly InputAction m_gameplay_shootBullet;
    private readonly InputAction m_gameplay_laserWirbel;
    private readonly InputAction m_gameplay_Rocket;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_gameplay_Walk;
        public InputAction @Rotate => m_Wrapper.m_gameplay_Rotate;
        public InputAction @shootBullet => m_Wrapper.m_gameplay_shootBullet;
        public InputAction @laserWirbel => m_Wrapper.m_gameplay_laserWirbel;
        public InputAction @Rocket => m_Wrapper.m_gameplay_Rocket;
        public InputActionMap Get() { return m_Wrapper.m_gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWalk;
                @Rotate.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @shootBullet.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootBullet;
                @shootBullet.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootBullet;
                @shootBullet.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootBullet;
                @laserWirbel.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLaserWirbel;
                @laserWirbel.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLaserWirbel;
                @laserWirbel.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLaserWirbel;
                @Rocket.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRocket;
                @Rocket.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRocket;
                @Rocket.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRocket;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @shootBullet.started += instance.OnShootBullet;
                @shootBullet.performed += instance.OnShootBullet;
                @shootBullet.canceled += instance.OnShootBullet;
                @laserWirbel.started += instance.OnLaserWirbel;
                @laserWirbel.performed += instance.OnLaserWirbel;
                @laserWirbel.canceled += instance.OnLaserWirbel;
                @Rocket.started += instance.OnRocket;
                @Rocket.performed += instance.OnRocket;
                @Rocket.canceled += instance.OnRocket;
            }
        }
    }
    public GameplayActions @gameplay => new GameplayActions(this);
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnShootBullet(InputAction.CallbackContext context);
        void OnLaserWirbel(InputAction.CallbackContext context);
        void OnRocket(InputAction.CallbackContext context);
    }
}
