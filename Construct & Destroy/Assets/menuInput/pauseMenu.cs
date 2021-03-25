// GENERATED AUTOMATICALLY FROM 'Assets/menuInput/pauseMenu.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PauseMenu : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PauseMenu()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""pauseMenu"",
    ""maps"": [
        {
            ""name"": ""input"",
            ""id"": ""d498addc-ce66-4490-9abc-c6b3bfb3c418"",
            ""actions"": [
                {
                    ""name"": ""call"",
                    ""type"": ""Button"",
                    ""id"": ""80653158-43f7-41cd-81a8-1b697db25e01"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveDown"",
                    ""type"": ""Button"",
                    ""id"": ""9e73fd6e-9170-43fd-be77-684777b6c717"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveUp"",
                    ""type"": ""Button"",
                    ""id"": ""5d947b97-d84e-4788-8b5b-ce1e589a5446"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""select"",
                    ""type"": ""Button"",
                    ""id"": ""55e12998-448c-47c6-91e9-7474debb7265"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ec5bc8d2-e934-4d20-b61f-87bee7579a7b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""call"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c44c3e81-c66c-4ebb-ac04-c5e6cefe523d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""call"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6c10a06-1f1f-46b6-968b-75166d5a48c9"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""moveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fb119d8-0421-4606-ab42-9a41cf013b2e"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""moveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e019787-05b6-4f53-aaa2-8314b5b22849"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""select"",
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
                    ""devicePath"": ""<Gamepad>"",
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
        // input
        m_input = asset.FindActionMap("input", throwIfNotFound: true);
        m_input_call = m_input.FindAction("call", throwIfNotFound: true);
        m_input_moveDown = m_input.FindAction("moveDown", throwIfNotFound: true);
        m_input_moveUp = m_input.FindAction("moveUp", throwIfNotFound: true);
        m_input_select = m_input.FindAction("select", throwIfNotFound: true);
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
    private readonly InputAction m_input_call;
    private readonly InputAction m_input_moveDown;
    private readonly InputAction m_input_moveUp;
    private readonly InputAction m_input_select;
    public struct InputActions
    {
        private @PauseMenu m_Wrapper;
        public InputActions(@PauseMenu wrapper) { m_Wrapper = wrapper; }
        public InputAction @call => m_Wrapper.m_input_call;
        public InputAction @moveDown => m_Wrapper.m_input_moveDown;
        public InputAction @moveUp => m_Wrapper.m_input_moveUp;
        public InputAction @select => m_Wrapper.m_input_select;
        public InputActionMap Get() { return m_Wrapper.m_input; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputActions set) { return set.Get(); }
        public void SetCallbacks(IInputActions instance)
        {
            if (m_Wrapper.m_InputActionsCallbackInterface != null)
            {
                @call.started -= m_Wrapper.m_InputActionsCallbackInterface.OnCall;
                @call.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnCall;
                @call.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnCall;
                @moveDown.started -= m_Wrapper.m_InputActionsCallbackInterface.OnMoveDown;
                @moveDown.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnMoveDown;
                @moveDown.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnMoveDown;
                @moveUp.started -= m_Wrapper.m_InputActionsCallbackInterface.OnMoveUp;
                @moveUp.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnMoveUp;
                @moveUp.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnMoveUp;
                @select.started -= m_Wrapper.m_InputActionsCallbackInterface.OnSelect;
                @select.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnSelect;
                @select.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_InputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @call.started += instance.OnCall;
                @call.performed += instance.OnCall;
                @call.canceled += instance.OnCall;
                @moveDown.started += instance.OnMoveDown;
                @moveDown.performed += instance.OnMoveDown;
                @moveDown.canceled += instance.OnMoveDown;
                @moveUp.started += instance.OnMoveUp;
                @moveUp.performed += instance.OnMoveUp;
                @moveUp.canceled += instance.OnMoveUp;
                @select.started += instance.OnSelect;
                @select.performed += instance.OnSelect;
                @select.canceled += instance.OnSelect;
            }
        }
    }
    public InputActions @input => new InputActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface IInputActions
    {
        void OnCall(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnMoveUp(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
}
