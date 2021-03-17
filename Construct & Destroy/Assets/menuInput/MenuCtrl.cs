// GENERATED AUTOMATICALLY FROM 'Assets/menuInput/menuCtrl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MenuCtrl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MenuCtrl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""menuCtrl"",
    ""maps"": [
        {
            ""name"": ""input"",
            ""id"": ""35e409f7-7a3d-46c5-8a38-9f6cb938a482"",
            ""actions"": [
                {
                    ""name"": ""confirm"",
                    ""type"": ""Button"",
                    ""id"": ""c6e0af3a-3b6f-40b3-8d73-8ca261f53b1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""start"",
                    ""type"": ""Button"",
                    ""id"": ""9850a82c-4a6a-4131-83ef-2a0613034e2b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""down"",
                    ""type"": ""Button"",
                    ""id"": ""8f672887-f3e5-4b80-99e7-8a56c7ada99c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""up"",
                    ""type"": ""Button"",
                    ""id"": ""099e13ce-315a-4351-9757-eb635ba64f68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e3aab4d9-29d5-4a7b-886b-e42e4e61b83d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller1"",
                    ""action"": ""confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cafeadb4-026a-417f-83e4-e54d4e1eed02"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4827740e-0fee-4ab2-89c9-b908c4493a4c"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller1"",
                    ""action"": ""down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""261593d8-9161-4404-bdb5-a8929a512bbf"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller1"",
                    ""action"": ""up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""controller1"",
            ""bindingGroup"": ""controller1"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // input
        m_input = asset.FindActionMap("input", throwIfNotFound: true);
        m_input_confirm = m_input.FindAction("confirm", throwIfNotFound: true);
        m_input_start = m_input.FindAction("start", throwIfNotFound: true);
        m_input_down = m_input.FindAction("down", throwIfNotFound: true);
        m_input_up = m_input.FindAction("up", throwIfNotFound: true);
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

    // input
    private readonly InputActionMap m_input;
    private IInputActions m_InputActionsCallbackInterface;
    private readonly InputAction m_input_confirm;
    private readonly InputAction m_input_start;
    private readonly InputAction m_input_down;
    private readonly InputAction m_input_up;
    public struct InputActions
    {
        private @MenuCtrl m_Wrapper;
        public InputActions(@MenuCtrl wrapper) { m_Wrapper = wrapper; }
        public InputAction @confirm => m_Wrapper.m_input_confirm;
        public InputAction @start => m_Wrapper.m_input_start;
        public InputAction @down => m_Wrapper.m_input_down;
        public InputAction @up => m_Wrapper.m_input_up;
        public InputActionMap Get() { return m_Wrapper.m_input; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputActions set) { return set.Get(); }
        public void SetCallbacks(IInputActions instance)
        {
            if (m_Wrapper.m_InputActionsCallbackInterface != null)
            {
                @confirm.started -= m_Wrapper.m_InputActionsCallbackInterface.OnConfirm;
                @confirm.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnConfirm;
                @confirm.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnConfirm;
                @start.started -= m_Wrapper.m_InputActionsCallbackInterface.OnStart;
                @start.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnStart;
                @start.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnStart;
                @down.started -= m_Wrapper.m_InputActionsCallbackInterface.OnDown;
                @down.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnDown;
                @down.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnDown;
                @up.started -= m_Wrapper.m_InputActionsCallbackInterface.OnUp;
                @up.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnUp;
                @up.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnUp;
            }
            m_Wrapper.m_InputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @confirm.started += instance.OnConfirm;
                @confirm.performed += instance.OnConfirm;
                @confirm.canceled += instance.OnConfirm;
                @start.started += instance.OnStart;
                @start.performed += instance.OnStart;
                @start.canceled += instance.OnStart;
                @down.started += instance.OnDown;
                @down.performed += instance.OnDown;
                @down.canceled += instance.OnDown;
                @up.started += instance.OnUp;
                @up.performed += instance.OnUp;
                @up.canceled += instance.OnUp;
            }
        }
    }
    public InputActions @input => new InputActions(this);
    private int m_controller1SchemeIndex = -1;
    public InputControlScheme controller1Scheme
    {
        get
        {
            if (m_controller1SchemeIndex == -1) m_controller1SchemeIndex = asset.FindControlSchemeIndex("controller1");
            return asset.controlSchemes[m_controller1SchemeIndex];
        }
    }
    public interface IInputActions
    {
        void OnConfirm(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
    }
}
