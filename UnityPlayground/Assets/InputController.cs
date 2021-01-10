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
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ec84ee15-d72c-42e8-9203-242fab8887e7"",
                    ""path"": ""<Keyboard>/s"",
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
                    ""path"": ""<Keyboard>/w"",
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
                    ""path"": ""<Keyboard>/d"",
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
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftButton"",
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
    public struct CharacterInputActions
    {
        private @InputController m_Wrapper;
        public CharacterInputActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @DownButton => m_Wrapper.m_CharacterInput_DownButton;
        public InputAction @UpButton => m_Wrapper.m_CharacterInput_UpButton;
        public InputAction @RunButton => m_Wrapper.m_CharacterInput_RunButton;
        public InputAction @RightButton => m_Wrapper.m_CharacterInput_RightButton;
        public InputAction @LeftButton => m_Wrapper.m_CharacterInput_LeftButton;
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
            }
        }
    }
    public CharacterInputActions @CharacterInput => new CharacterInputActions(this);
    public interface ICharacterInputActions
    {
        void OnDownButton(InputAction.CallbackContext context);
        void OnUpButton(InputAction.CallbackContext context);
        void OnRunButton(InputAction.CallbackContext context);
        void OnRightButton(InputAction.CallbackContext context);
        void OnLeftButton(InputAction.CallbackContext context);
    }
}
