// GENERATED AUTOMATICALLY FROM 'Assets/keyboardControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @KeyboardControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @KeyboardControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""keyboardControls"",
    ""maps"": [
        {
            ""name"": ""gameplayEast"",
            ""id"": ""79d6373a-7343-4ad9-bf02-f252412eb771"",
            ""actions"": [
                {
                    ""name"": ""walk"",
                    ""type"": ""Value"",
                    ""id"": ""47b6c3d8-79ef-48b5-a45c-46a11abd5959"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rotate"",
                    ""type"": ""Value"",
                    ""id"": ""341c6e03-4358-411e-bb69-43c417105819"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shootBullet"",
                    ""type"": ""Button"",
                    ""id"": ""057470b7-cd97-45a2-8867-b366ae8a3c4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""laserWirbel"",
                    ""type"": ""Button"",
                    ""id"": ""f11f5936-3d1e-43df-9e53-4c61337c0848"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rocketShot"",
                    ""type"": ""Button"",
                    ""id"": ""f6986c72-76a5-48c9-a198-274cbc7f6d29"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8bf212a2-e448-4587-9fd4-cf2d04379ce6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e60a5f71-2d5a-449c-8316-48fee2f6005d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""mouse"",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9cefcd1d-81b9-4773-9c6b-f5f983c08c8e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""mouse"",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""48d5807e-76f8-4b07-98c4-dd48ec6f32d0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""mouse"",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e0439b2c-a0cb-4d72-86de-f39c9ddf68f6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""mouse"",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""489033a0-2946-4e85-b9f9-6b74794c1eff"",
                    ""path"": ""<Pointer>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""mouse"",
                    ""action"": ""rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a60b1aeb-ae13-47f0-be24-8d124243b5d9"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""mouse"",
                    ""action"": ""shootBullet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b229b349-02ba-4490-bb0a-33b751c7c01d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""mouse"",
                    ""action"": ""laserWirbel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""707071c3-a865-4800-8f25-bf954f816c67"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""mouse"",
                    ""action"": ""rocketShot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""mouse"",
            ""bindingGroup"": ""mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // gameplayEast
        m_gameplayEast = asset.FindActionMap("gameplayEast", throwIfNotFound: true);
        m_gameplayEast_walk = m_gameplayEast.FindAction("walk", throwIfNotFound: true);
        m_gameplayEast_rotate = m_gameplayEast.FindAction("rotate", throwIfNotFound: true);
        m_gameplayEast_shootBullet = m_gameplayEast.FindAction("shootBullet", throwIfNotFound: true);
        m_gameplayEast_laserWirbel = m_gameplayEast.FindAction("laserWirbel", throwIfNotFound: true);
        m_gameplayEast_rocketShot = m_gameplayEast.FindAction("rocketShot", throwIfNotFound: true);
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

    // gameplayEast
    private readonly InputActionMap m_gameplayEast;
    private IGameplayEastActions m_GameplayEastActionsCallbackInterface;
    private readonly InputAction m_gameplayEast_walk;
    private readonly InputAction m_gameplayEast_rotate;
    private readonly InputAction m_gameplayEast_shootBullet;
    private readonly InputAction m_gameplayEast_laserWirbel;
    private readonly InputAction m_gameplayEast_rocketShot;
    public struct GameplayEastActions
    {
        private @KeyboardControls m_Wrapper;
        public GameplayEastActions(@KeyboardControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @walk => m_Wrapper.m_gameplayEast_walk;
        public InputAction @rotate => m_Wrapper.m_gameplayEast_rotate;
        public InputAction @shootBullet => m_Wrapper.m_gameplayEast_shootBullet;
        public InputAction @laserWirbel => m_Wrapper.m_gameplayEast_laserWirbel;
        public InputAction @rocketShot => m_Wrapper.m_gameplayEast_rocketShot;
        public InputActionMap Get() { return m_Wrapper.m_gameplayEast; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayEastActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayEastActions instance)
        {
            if (m_Wrapper.m_GameplayEastActionsCallbackInterface != null)
            {
                @walk.started -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnWalk;
                @walk.performed -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnWalk;
                @walk.canceled -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnWalk;
                @rotate.started -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnRotate;
                @rotate.performed -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnRotate;
                @rotate.canceled -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnRotate;
                @shootBullet.started -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnShootBullet;
                @shootBullet.performed -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnShootBullet;
                @shootBullet.canceled -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnShootBullet;
                @laserWirbel.started -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnLaserWirbel;
                @laserWirbel.performed -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnLaserWirbel;
                @laserWirbel.canceled -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnLaserWirbel;
                @rocketShot.started -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnRocketShot;
                @rocketShot.performed -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnRocketShot;
                @rocketShot.canceled -= m_Wrapper.m_GameplayEastActionsCallbackInterface.OnRocketShot;
            }
            m_Wrapper.m_GameplayEastActionsCallbackInterface = instance;
            if (instance != null)
            {
                @walk.started += instance.OnWalk;
                @walk.performed += instance.OnWalk;
                @walk.canceled += instance.OnWalk;
                @rotate.started += instance.OnRotate;
                @rotate.performed += instance.OnRotate;
                @rotate.canceled += instance.OnRotate;
                @shootBullet.started += instance.OnShootBullet;
                @shootBullet.performed += instance.OnShootBullet;
                @shootBullet.canceled += instance.OnShootBullet;
                @laserWirbel.started += instance.OnLaserWirbel;
                @laserWirbel.performed += instance.OnLaserWirbel;
                @laserWirbel.canceled += instance.OnLaserWirbel;
                @rocketShot.started += instance.OnRocketShot;
                @rocketShot.performed += instance.OnRocketShot;
                @rocketShot.canceled += instance.OnRocketShot;
            }
        }
    }
    public GameplayEastActions @gameplayEast => new GameplayEastActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    private int m_mouseSchemeIndex = -1;
    public InputControlScheme mouseScheme
    {
        get
        {
            if (m_mouseSchemeIndex == -1) m_mouseSchemeIndex = asset.FindControlSchemeIndex("mouse");
            return asset.controlSchemes[m_mouseSchemeIndex];
        }
    }
    public interface IGameplayEastActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnShootBullet(InputAction.CallbackContext context);
        void OnLaserWirbel(InputAction.CallbackContext context);
        void OnRocketShot(InputAction.CallbackContext context);
    }
}
