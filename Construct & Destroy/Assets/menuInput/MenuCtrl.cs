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
                },
                {
                    ""name"": ""back"",
                    ""type"": ""Button"",
                    ""id"": ""f0f1c8b2-e1c7-43dd-8a8e-589c2b202a79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""sliderRight"",
                    ""type"": ""Button"",
                    ""id"": ""5a87a24f-bdcf-4155-b0fc-31633eb28b26"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""sliderLeft"",
                    ""type"": ""Button"",
                    ""id"": ""38382ae4-5531-4eb2-aa1f-6b1a509ec0f0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""switchRight"",
                    ""type"": ""Button"",
                    ""id"": ""b582cf0e-8542-437d-a109-47dbb13a6e4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""switchLeft"",
                    ""type"": ""Button"",
                    ""id"": ""53658781-e915-4d12-9cd8-bb7d0a6b6222"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""b8c600a0-1108-487f-9ac3-161a9283bbb3"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c9fb347-0f43-4d13-9c0f-5cdbdc722b10"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller1"",
                    ""action"": ""sliderRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14db8945-a843-4a08-8c23-7d983aae5216"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller1"",
                    ""action"": ""sliderLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81fa9a1d-8c3b-445e-a0df-f34f04f11dc9"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller1"",
                    ""action"": ""switchRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c0a7d4c-ab51-4af5-826f-c742b4e42fa2"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller1"",
                    ""action"": ""switchLeft"",
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
        m_input_back = m_input.FindAction("back", throwIfNotFound: true);
        m_input_sliderRight = m_input.FindAction("sliderRight", throwIfNotFound: true);
        m_input_sliderLeft = m_input.FindAction("sliderLeft", throwIfNotFound: true);
        m_input_switchRight = m_input.FindAction("switchRight", throwIfNotFound: true);
        m_input_switchLeft = m_input.FindAction("switchLeft", throwIfNotFound: true);
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
    private readonly InputAction m_input_back;
    private readonly InputAction m_input_sliderRight;
    private readonly InputAction m_input_sliderLeft;
    private readonly InputAction m_input_switchRight;
    private readonly InputAction m_input_switchLeft;
    public struct InputActions
    {
        private @MenuCtrl m_Wrapper;
        public InputActions(@MenuCtrl wrapper) { m_Wrapper = wrapper; }
        public InputAction @confirm => m_Wrapper.m_input_confirm;
        public InputAction @start => m_Wrapper.m_input_start;
        public InputAction @down => m_Wrapper.m_input_down;
        public InputAction @up => m_Wrapper.m_input_up;
        public InputAction @back => m_Wrapper.m_input_back;
        public InputAction @sliderRight => m_Wrapper.m_input_sliderRight;
        public InputAction @sliderLeft => m_Wrapper.m_input_sliderLeft;
        public InputAction @switchRight => m_Wrapper.m_input_switchRight;
        public InputAction @switchLeft => m_Wrapper.m_input_switchLeft;
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
                @back.started -= m_Wrapper.m_InputActionsCallbackInterface.OnBack;
                @back.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnBack;
                @back.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnBack;
                @sliderRight.started -= m_Wrapper.m_InputActionsCallbackInterface.OnSliderRight;
                @sliderRight.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnSliderRight;
                @sliderRight.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnSliderRight;
                @sliderLeft.started -= m_Wrapper.m_InputActionsCallbackInterface.OnSliderLeft;
                @sliderLeft.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnSliderLeft;
                @sliderLeft.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnSliderLeft;
                @switchRight.started -= m_Wrapper.m_InputActionsCallbackInterface.OnSwitchRight;
                @switchRight.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnSwitchRight;
                @switchRight.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnSwitchRight;
                @switchLeft.started -= m_Wrapper.m_InputActionsCallbackInterface.OnSwitchLeft;
                @switchLeft.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnSwitchLeft;
                @switchLeft.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnSwitchLeft;
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
                @back.started += instance.OnBack;
                @back.performed += instance.OnBack;
                @back.canceled += instance.OnBack;
                @sliderRight.started += instance.OnSliderRight;
                @sliderRight.performed += instance.OnSliderRight;
                @sliderRight.canceled += instance.OnSliderRight;
                @sliderLeft.started += instance.OnSliderLeft;
                @sliderLeft.performed += instance.OnSliderLeft;
                @sliderLeft.canceled += instance.OnSliderLeft;
                @switchRight.started += instance.OnSwitchRight;
                @switchRight.performed += instance.OnSwitchRight;
                @switchRight.canceled += instance.OnSwitchRight;
                @switchLeft.started += instance.OnSwitchLeft;
                @switchLeft.performed += instance.OnSwitchLeft;
                @switchLeft.canceled += instance.OnSwitchLeft;
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
        void OnBack(InputAction.CallbackContext context);
        void OnSliderRight(InputAction.CallbackContext context);
        void OnSliderLeft(InputAction.CallbackContext context);
        void OnSwitchRight(InputAction.CallbackContext context);
        void OnSwitchLeft(InputAction.CallbackContext context);
    }
}
