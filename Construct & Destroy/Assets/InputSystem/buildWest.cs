// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/buildWest.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BuildWest : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BuildWest()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""buildWest"",
    ""maps"": [
        {
            ""name"": ""build"",
            ""id"": ""08d2f481-3d52-4a0e-b5ff-cd006dd56bfe"",
            ""actions"": [
                {
                    ""name"": ""moveUp"",
                    ""type"": ""Button"",
                    ""id"": ""e73b59ae-ec16-4531-afc9-44135ee559da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveDown"",
                    ""type"": ""Button"",
                    ""id"": ""9abbf10d-52ab-46f8-913a-e194482ca76e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""6fbd7881-f52f-44ca-b532-a4896955d901"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveRight"",
                    ""type"": ""Button"",
                    ""id"": ""ef0fd10b-a3f4-4e99-a340-addaad87f8a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""select"",
                    ""type"": ""Button"",
                    ""id"": ""2c9b4543-e18c-4f13-9777-cef2fbecac86"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""plant"",
                    ""type"": ""Button"",
                    ""id"": ""0f1eb235-93eb-48b7-bf96-48ad5b2fcf70"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cancel"",
                    ""type"": ""Button"",
                    ""id"": ""23707f7d-f674-4d89-9f45-c7463a55a830"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""switchLeft"",
                    ""type"": ""Button"",
                    ""id"": ""27f2fbb9-9279-48d8-806e-0739a55d35e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""switchRight"",
                    ""type"": ""Button"",
                    ""id"": ""728711c5-4024-4fa8-91d1-1897d8ebf0f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6ab6f068-7478-421b-9c86-b84598fa2fbe"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0837201-b003-4804-aac2-1a11d0cdd065"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a3d33ee-39e4-4e70-af4c-47c67927fa61"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ctrl"",
                    ""action"": ""moveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31f9eb5e-0584-4b00-ba07-31bcaa6293a6"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ctrl"",
                    ""action"": ""moveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""206501d6-85ed-477c-8c38-5c0b1fe95549"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ctrl"",
                    ""action"": ""select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca725883-01e2-4d22-8f1a-00963fbd7be1"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ctrl"",
                    ""action"": ""plant"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d685e37f-8f07-4641-97ac-5f311b48539a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ctrl"",
                    ""action"": ""cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cac9ab3-4883-40d3-b2f0-4fbd5a188e1f"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ctrl"",
                    ""action"": ""switchLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4d6a766-b4a8-4169-8f34-74c3e203822a"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ctrl"",
                    ""action"": ""switchRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""ctrl"",
            ""bindingGroup"": ""ctrl"",
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
        // build
        m_build = asset.FindActionMap("build", throwIfNotFound: true);
        m_build_moveUp = m_build.FindAction("moveUp", throwIfNotFound: true);
        m_build_moveDown = m_build.FindAction("moveDown", throwIfNotFound: true);
        m_build_moveLeft = m_build.FindAction("moveLeft", throwIfNotFound: true);
        m_build_moveRight = m_build.FindAction("moveRight", throwIfNotFound: true);
        m_build_select = m_build.FindAction("select", throwIfNotFound: true);
        m_build_plant = m_build.FindAction("plant", throwIfNotFound: true);
        m_build_cancel = m_build.FindAction("cancel", throwIfNotFound: true);
        m_build_switchLeft = m_build.FindAction("switchLeft", throwIfNotFound: true);
        m_build_switchRight = m_build.FindAction("switchRight", throwIfNotFound: true);
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
    private readonly InputAction m_build_select;
    private readonly InputAction m_build_plant;
    private readonly InputAction m_build_cancel;
    private readonly InputAction m_build_switchLeft;
    private readonly InputAction m_build_switchRight;
    public struct BuildActions
    {
        private @BuildWest m_Wrapper;
        public BuildActions(@BuildWest wrapper) { m_Wrapper = wrapper; }
        public InputAction @moveUp => m_Wrapper.m_build_moveUp;
        public InputAction @moveDown => m_Wrapper.m_build_moveDown;
        public InputAction @moveLeft => m_Wrapper.m_build_moveLeft;
        public InputAction @moveRight => m_Wrapper.m_build_moveRight;
        public InputAction @select => m_Wrapper.m_build_select;
        public InputAction @plant => m_Wrapper.m_build_plant;
        public InputAction @cancel => m_Wrapper.m_build_cancel;
        public InputAction @switchLeft => m_Wrapper.m_build_switchLeft;
        public InputAction @switchRight => m_Wrapper.m_build_switchRight;
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
                @select.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnSelect;
                @select.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnSelect;
                @select.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnSelect;
                @plant.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnPlant;
                @plant.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnPlant;
                @plant.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnPlant;
                @cancel.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnCancel;
                @cancel.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnCancel;
                @cancel.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnCancel;
                @switchLeft.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnSwitchLeft;
                @switchLeft.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnSwitchLeft;
                @switchLeft.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnSwitchLeft;
                @switchRight.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnSwitchRight;
                @switchRight.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnSwitchRight;
                @switchRight.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnSwitchRight;
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
                @select.started += instance.OnSelect;
                @select.performed += instance.OnSelect;
                @select.canceled += instance.OnSelect;
                @plant.started += instance.OnPlant;
                @plant.performed += instance.OnPlant;
                @plant.canceled += instance.OnPlant;
                @cancel.started += instance.OnCancel;
                @cancel.performed += instance.OnCancel;
                @cancel.canceled += instance.OnCancel;
                @switchLeft.started += instance.OnSwitchLeft;
                @switchLeft.performed += instance.OnSwitchLeft;
                @switchLeft.canceled += instance.OnSwitchLeft;
                @switchRight.started += instance.OnSwitchRight;
                @switchRight.performed += instance.OnSwitchRight;
                @switchRight.canceled += instance.OnSwitchRight;
            }
        }
    }
    public BuildActions @build => new BuildActions(this);
    private int m_ctrlSchemeIndex = -1;
    public InputControlScheme ctrlScheme
    {
        get
        {
            if (m_ctrlSchemeIndex == -1) m_ctrlSchemeIndex = asset.FindControlSchemeIndex("ctrl");
            return asset.controlSchemes[m_ctrlSchemeIndex];
        }
    }
    public interface IBuildActions
    {
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnPlant(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnSwitchLeft(InputAction.CallbackContext context);
        void OnSwitchRight(InputAction.CallbackContext context);
    }
}
