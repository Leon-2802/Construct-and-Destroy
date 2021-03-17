// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/buildEast.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BuildEast : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BuildEast()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""buildEast"",
    ""maps"": [
        {
            ""name"": ""build"",
            ""id"": ""8a961f93-a32e-4396-9c08-daf4a3c58949"",
            ""actions"": [
                {
                    ""name"": ""moveUp"",
                    ""type"": ""Button"",
                    ""id"": ""648feb97-4f6f-473e-b582-472d4bc7e6e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveDown"",
                    ""type"": ""Button"",
                    ""id"": ""5b06a7e8-293d-4938-93f8-4bd1f097fb53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""d1cf78ff-c95f-4e84-89f4-bcc756fd4eaa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveRight"",
                    ""type"": ""Button"",
                    ""id"": ""a315eba3-dbc1-48de-bc60-2f3846ea50ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""switchLeft"",
                    ""type"": ""Button"",
                    ""id"": ""80425c53-d9e6-4da3-aadb-3cb8029291e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""switchRight"",
                    ""type"": ""Button"",
                    ""id"": ""a5d68f43-fa69-4de9-9e87-b595ff092eb0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""plant"",
                    ""type"": ""Button"",
                    ""id"": ""c8e1cb26-0d3c-491c-ba8c-ea1e9e028ef6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cancel"",
                    ""type"": ""Button"",
                    ""id"": ""7615a557-6405-4b37-9609-6ab8c2f2ab4d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""select"",
                    ""type"": ""Button"",
                    ""id"": ""9bf1199c-dfb7-4fcf-851e-9649b0dc2203"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""75cbb9ab-7334-4ec2-ba17-63a8e57657cb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""moveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f68525b0-876e-4897-8f7c-6e0a9c3f1b1e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""moveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2de5679-a179-45fe-b4df-fca0bfa79310"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""moveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48ee6003-8a7a-4998-9aca-0388660b6315"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""moveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d8379f4-1457-4f14-b98b-2eb8c8c02b49"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""switchLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""280c4dde-a18a-40cb-b978-0a3ae1fafe4d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""switchRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b39e4a6-d3a3-4dc9-81fe-155d1945b60e"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""plant"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ca1bfd9-fefe-4e56-a546-976c4ce714f1"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""077952e6-501b-4f9e-a539-ec6b51835764"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""keyboard"",
            ""bindingGroup"": ""keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // build
        m_build = asset.FindActionMap("build", throwIfNotFound: true);
        m_build_moveUp = m_build.FindAction("moveUp", throwIfNotFound: true);
        m_build_moveDown = m_build.FindAction("moveDown", throwIfNotFound: true);
        m_build_moveLeft = m_build.FindAction("moveLeft", throwIfNotFound: true);
        m_build_moveRight = m_build.FindAction("moveRight", throwIfNotFound: true);
        m_build_switchLeft = m_build.FindAction("switchLeft", throwIfNotFound: true);
        m_build_switchRight = m_build.FindAction("switchRight", throwIfNotFound: true);
        m_build_plant = m_build.FindAction("plant", throwIfNotFound: true);
        m_build_cancel = m_build.FindAction("cancel", throwIfNotFound: true);
        m_build_select = m_build.FindAction("select", throwIfNotFound: true);
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

    // build
    private readonly InputActionMap m_build;
    private IBuildActions m_BuildActionsCallbackInterface;
    private readonly InputAction m_build_moveUp;
    private readonly InputAction m_build_moveDown;
    private readonly InputAction m_build_moveLeft;
    private readonly InputAction m_build_moveRight;
    private readonly InputAction m_build_switchLeft;
    private readonly InputAction m_build_switchRight;
    private readonly InputAction m_build_plant;
    private readonly InputAction m_build_cancel;
    private readonly InputAction m_build_select;
    public struct BuildActions
    {
        private @BuildEast m_Wrapper;
        public BuildActions(@BuildEast wrapper) { m_Wrapper = wrapper; }
        public InputAction @moveUp => m_Wrapper.m_build_moveUp;
        public InputAction @moveDown => m_Wrapper.m_build_moveDown;
        public InputAction @moveLeft => m_Wrapper.m_build_moveLeft;
        public InputAction @moveRight => m_Wrapper.m_build_moveRight;
        public InputAction @switchLeft => m_Wrapper.m_build_switchLeft;
        public InputAction @switchRight => m_Wrapper.m_build_switchRight;
        public InputAction @plant => m_Wrapper.m_build_plant;
        public InputAction @cancel => m_Wrapper.m_build_cancel;
        public InputAction @select => m_Wrapper.m_build_select;
        public InputActionMap Get() { return m_Wrapper.m_build; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BuildActions set) { return set.Get(); }
        public void SetCallbacks(IBuildActions instance)
        {
            if (m_Wrapper.m_BuildActionsCallbackInterface != null)
            {
                @moveUp.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnMoveUp;
                @moveUp.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnMoveUp;
                @moveUp.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnMoveUp;
                @moveDown.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnMoveDown;
                @moveDown.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnMoveDown;
                @moveDown.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnMoveDown;
                @moveLeft.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnMoveLeft;
                @moveLeft.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnMoveLeft;
                @moveLeft.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnMoveLeft;
                @moveRight.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnMoveRight;
                @moveRight.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnMoveRight;
                @moveRight.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnMoveRight;
                @switchLeft.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnSwitchLeft;
                @switchLeft.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnSwitchLeft;
                @switchLeft.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnSwitchLeft;
                @switchRight.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnSwitchRight;
                @switchRight.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnSwitchRight;
                @switchRight.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnSwitchRight;
                @plant.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnPlant;
                @plant.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnPlant;
                @plant.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnPlant;
                @cancel.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnCancel;
                @cancel.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnCancel;
                @cancel.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnCancel;
                @select.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnSelect;
                @select.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnSelect;
                @select.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_BuildActionsCallbackInterface = instance;
            if (instance != null)
            {
                @moveUp.started += instance.OnMoveUp;
                @moveUp.performed += instance.OnMoveUp;
                @moveUp.canceled += instance.OnMoveUp;
                @moveDown.started += instance.OnMoveDown;
                @moveDown.performed += instance.OnMoveDown;
                @moveDown.canceled += instance.OnMoveDown;
                @moveLeft.started += instance.OnMoveLeft;
                @moveLeft.performed += instance.OnMoveLeft;
                @moveLeft.canceled += instance.OnMoveLeft;
                @moveRight.started += instance.OnMoveRight;
                @moveRight.performed += instance.OnMoveRight;
                @moveRight.canceled += instance.OnMoveRight;
                @switchLeft.started += instance.OnSwitchLeft;
                @switchLeft.performed += instance.OnSwitchLeft;
                @switchLeft.canceled += instance.OnSwitchLeft;
                @switchRight.started += instance.OnSwitchRight;
                @switchRight.performed += instance.OnSwitchRight;
                @switchRight.canceled += instance.OnSwitchRight;
                @plant.started += instance.OnPlant;
                @plant.performed += instance.OnPlant;
                @plant.canceled += instance.OnPlant;
                @cancel.started += instance.OnCancel;
                @cancel.performed += instance.OnCancel;
                @cancel.canceled += instance.OnCancel;
                @select.started += instance.OnSelect;
                @select.performed += instance.OnSelect;
                @select.canceled += instance.OnSelect;
            }
        }
    }
    public BuildActions @build => new BuildActions(this);
    private int m_keyboardSchemeIndex = -1;
    public InputControlScheme keyboardScheme
    {
        get
        {
            if (m_keyboardSchemeIndex == -1) m_keyboardSchemeIndex = asset.FindControlSchemeIndex("keyboard");
            return asset.controlSchemes[m_keyboardSchemeIndex];
        }
    }
    public interface IBuildActions
    {
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnSwitchLeft(InputAction.CallbackContext context);
        void OnSwitchRight(InputAction.CallbackContext context);
        void OnPlant(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
}
