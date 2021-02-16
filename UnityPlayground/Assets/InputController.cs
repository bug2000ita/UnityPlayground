// GENERATED AUTOMATICALLY FROM 'Assets/InputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""CharacterInput"",
            ""id"": ""61b8cbbf-05eb-4a49-b231-c07ed5c377a5"",
            ""actions"": [
                {
                    ""name"": ""DownButton"",
                    ""type"": ""Button"",
                    ""id"": ""6f220cdd-8d75-4b2e-9285-6b85a0aa91db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpButton"",
                    ""type"": ""Button"",
                    ""id"": ""603dbac3-6b46-45a6-9a90-a121405aa7cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RunButton"",
                    ""type"": ""Button"",
                    ""id"": ""156e38dd-884c-49b3-b487-b152f58ed00d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightButton"",
                    ""type"": ""Button"",
                    ""id"": ""489aa19c-a69c-4bb0-bbad-7b828f48badb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftButton"",
                    ""type"": ""Button"",
                    ""id"": ""97fd4925-457e-4222-bff6-41e746bee5ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpButton"",
                    ""type"": ""Button"",
                    ""id"": ""81b87cb0-196a-4946-8068-c7b1c8783af0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ec84ee15-d72c-42e8-9203-242fab8887e7"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f086dcb5-504a-4e2f-8207-88671bb6b41b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24edff47-f576-4030-9192-e25ce9c9af7e"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RunButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8501c104-d3db-4e98-832b-31a50e22d81f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52273347-e80a-4331-b1ad-bb19cd4dc5a4"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af5ccb4a-ada5-4f1c-b4d1-dc620a6e4192"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CameraInput"",
            ""id"": ""8e317db2-ca6a-46e0-bd42-5a1c026aee9f"",
            ""actions"": [
                {
                    ""name"": ""TurnLeft"",
                    ""type"": ""Button"",
                    ""id"": ""9020d033-cf47-40e5-8401-0d5e7ba5b160"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""TurnRight"",
                    ""type"": ""Button"",
                    ""id"": ""57d5e62c-d51e-4f18-8dc0-f90c9b48f85a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""TurnUp"",
                    ""type"": ""Button"",
                    ""id"": ""e698d13b-75f8-45c0-b5fb-f60032f5bb1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""TurnDown"",
                    ""type"": ""Button"",
                    ""id"": ""1f8b6d84-4963-415f-bd7e-b5cbaa051983"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f0676873-7c18-44ab-8c44-b0a600081d98"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8abec1de-277e-4683-a327-7991476f3d9b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5928fa8b-5e94-4d50-9e3d-23fd9ec70f12"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3fa465f7-e064-4d38-8072-fc7478ade278"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""id"": ""e07f0e89-f85a-4ec6-9d0b-bd83ab0c5358"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""7e601721-d856-4afb-ae60-050f8cd10628"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""07768df7-4679-4391-8921-1b8ce92ae112"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CharacterInput
        m_CharacterInput = asset.FindActionMap("CharacterInput", throwIfNotFound: true);
        m_CharacterInput_DownButton = m_CharacterInput.FindAction("DownButton", throwIfNotFound: true);
        m_CharacterInput_UpButton = m_CharacterInput.FindAction("UpButton", throwIfNotFound: true);
        m_CharacterInput_RunButton = m_CharacterInput.FindAction("RunButton", throwIfNotFound: true);
        m_CharacterInput_RightButton = m_CharacterInput.FindAction("RightButton", throwIfNotFound: true);
        m_CharacterInput_LeftButton = m_CharacterInput.FindAction("LeftButton", throwIfNotFound: true);
        m_CharacterInput_JumpButton = m_CharacterInput.FindAction("JumpButton", throwIfNotFound: true);
        // CameraInput
        m_CameraInput = asset.FindActionMap("CameraInput", throwIfNotFound: true);
        m_CameraInput_TurnLeft = m_CameraInput.FindAction("TurnLeft", throwIfNotFound: true);
        m_CameraInput_TurnRight = m_CameraInput.FindAction("TurnRight", throwIfNotFound: true);
        m_CameraInput_TurnUp = m_CameraInput.FindAction("TurnUp", throwIfNotFound: true);
        m_CameraInput_TurnDown = m_CameraInput.FindAction("TurnDown", throwIfNotFound: true);
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_Newaction = m_Mouse.FindAction("New action", throwIfNotFound: true);
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

    // CharacterInput
    private readonly InputActionMap m_CharacterInput;
    private ICharacterInputActions m_CharacterInputActionsCallbackInterface;
    private readonly InputAction m_CharacterInput_DownButton;
    private readonly InputAction m_CharacterInput_UpButton;
    private readonly InputAction m_CharacterInput_RunButton;
    private readonly InputAction m_CharacterInput_RightButton;
    private readonly InputAction m_CharacterInput_LeftButton;
    private readonly InputAction m_CharacterInput_JumpButton;
    public struct CharacterInputActions
    {
        private @InputController m_Wrapper;
        public CharacterInputActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @DownButton => m_Wrapper.m_CharacterInput_DownButton;
        public InputAction @UpButton => m_Wrapper.m_CharacterInput_UpButton;
        public InputAction @RunButton => m_Wrapper.m_CharacterInput_RunButton;
        public InputAction @RightButton => m_Wrapper.m_CharacterInput_RightButton;
        public InputAction @LeftButton => m_Wrapper.m_CharacterInput_LeftButton;
        public InputAction @JumpButton => m_Wrapper.m_CharacterInput_JumpButton;
        public InputActionMap Get() { return m_Wrapper.m_CharacterInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterInputActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterInputActions instance)
        {
            if (m_Wrapper.m_CharacterInputActionsCallbackInterface != null)
            {
                @DownButton.started -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnDownButton;
                @DownButton.performed -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnDownButton;
                @DownButton.canceled -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnDownButton;
                @UpButton.started -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnUpButton;
                @UpButton.performed -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnUpButton;
                @UpButton.canceled -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnUpButton;
                @RunButton.started -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnRunButton;
                @RunButton.performed -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnRunButton;
                @RunButton.canceled -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnRunButton;
                @RightButton.started -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnRightButton;
                @RightButton.performed -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnRightButton;
                @RightButton.canceled -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnRightButton;
                @LeftButton.started -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnLeftButton;
                @LeftButton.performed -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnLeftButton;
                @LeftButton.canceled -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnLeftButton;
                @JumpButton.started -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnJumpButton;
                @JumpButton.performed -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnJumpButton;
                @JumpButton.canceled -= m_Wrapper.m_CharacterInputActionsCallbackInterface.OnJumpButton;
            }
            m_Wrapper.m_CharacterInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DownButton.started += instance.OnDownButton;
                @DownButton.performed += instance.OnDownButton;
                @DownButton.canceled += instance.OnDownButton;
                @UpButton.started += instance.OnUpButton;
                @UpButton.performed += instance.OnUpButton;
                @UpButton.canceled += instance.OnUpButton;
                @RunButton.started += instance.OnRunButton;
                @RunButton.performed += instance.OnRunButton;
                @RunButton.canceled += instance.OnRunButton;
                @RightButton.started += instance.OnRightButton;
                @RightButton.performed += instance.OnRightButton;
                @RightButton.canceled += instance.OnRightButton;
                @LeftButton.started += instance.OnLeftButton;
                @LeftButton.performed += instance.OnLeftButton;
                @LeftButton.canceled += instance.OnLeftButton;
                @JumpButton.started += instance.OnJumpButton;
                @JumpButton.performed += instance.OnJumpButton;
                @JumpButton.canceled += instance.OnJumpButton;
            }
        }
    }
    public CharacterInputActions @CharacterInput => new CharacterInputActions(this);

    // CameraInput
    private readonly InputActionMap m_CameraInput;
    private ICameraInputActions m_CameraInputActionsCallbackInterface;
    private readonly InputAction m_CameraInput_TurnLeft;
    private readonly InputAction m_CameraInput_TurnRight;
    private readonly InputAction m_CameraInput_TurnUp;
    private readonly InputAction m_CameraInput_TurnDown;
    public struct CameraInputActions
    {
        private @InputController m_Wrapper;
        public CameraInputActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @TurnLeft => m_Wrapper.m_CameraInput_TurnLeft;
        public InputAction @TurnRight => m_Wrapper.m_CameraInput_TurnRight;
        public InputAction @TurnUp => m_Wrapper.m_CameraInput_TurnUp;
        public InputAction @TurnDown => m_Wrapper.m_CameraInput_TurnDown;
        public InputActionMap Get() { return m_Wrapper.m_CameraInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraInputActions set) { return set.Get(); }
        public void SetCallbacks(ICameraInputActions instance)
        {
            if (m_Wrapper.m_CameraInputActionsCallbackInterface != null)
            {
                @TurnLeft.started -= m_Wrapper.m_CameraInputActionsCallbackInterface.OnTurnLeft;
                @TurnLeft.performed -= m_Wrapper.m_CameraInputActionsCallbackInterface.OnTurnLeft;
                @TurnLeft.canceled -= m_Wrapper.m_CameraInputActionsCallbackInterface.OnTurnLeft;
                @TurnRight.started -= m_Wrapper.m_CameraInputActionsCallbackInterface.OnTurnRight;
                @TurnRight.performed -= m_Wrapper.m_CameraInputActionsCallbackInterface.OnTurnRight;
                @TurnRight.canceled -= m_Wrapper.m_CameraInputActionsCallbackInterface.OnTurnRight;
                @TurnUp.started -= m_Wrapper.m_CameraInputActionsCallbackInterface.OnTurnUp;
                @TurnUp.performed -= m_Wrapper.m_CameraInputActionsCallbackInterface.OnTurnUp;
                @TurnUp.canceled -= m_Wrapper.m_CameraInputActionsCallbackInterface.OnTurnUp;
                @TurnDown.started -= m_Wrapper.m_CameraInputActionsCallbackInterface.OnTurnDown;
                @TurnDown.performed -= m_Wrapper.m_CameraInputActionsCallbackInterface.OnTurnDown;
                @TurnDown.canceled -= m_Wrapper.m_CameraInputActionsCallbackInterface.OnTurnDown;
            }
            m_Wrapper.m_CameraInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TurnLeft.started += instance.OnTurnLeft;
                @TurnLeft.performed += instance.OnTurnLeft;
                @TurnLeft.canceled += instance.OnTurnLeft;
                @TurnRight.started += instance.OnTurnRight;
                @TurnRight.performed += instance.OnTurnRight;
                @TurnRight.canceled += instance.OnTurnRight;
                @TurnUp.started += instance.OnTurnUp;
                @TurnUp.performed += instance.OnTurnUp;
                @TurnUp.canceled += instance.OnTurnUp;
                @TurnDown.started += instance.OnTurnDown;
                @TurnDown.performed += instance.OnTurnDown;
                @TurnDown.canceled += instance.OnTurnDown;
            }
        }
    }
    public CameraInputActions @CameraInput => new CameraInputActions(this);

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_Newaction;
    public struct MouseActions
    {
        private @InputController m_Wrapper;
        public MouseActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Mouse_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);
    public interface ICharacterInputActions
    {
        void OnDownButton(InputAction.CallbackContext context);
        void OnUpButton(InputAction.CallbackContext context);
        void OnRunButton(InputAction.CallbackContext context);
        void OnRightButton(InputAction.CallbackContext context);
        void OnLeftButton(InputAction.CallbackContext context);
        void OnJumpButton(InputAction.CallbackContext context);
    }
    public interface ICameraInputActions
    {
        void OnTurnLeft(InputAction.CallbackContext context);
        void OnTurnRight(InputAction.CallbackContext context);
        void OnTurnUp(InputAction.CallbackContext context);
        void OnTurnDown(InputAction.CallbackContext context);
    }
    public interface IMouseActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
