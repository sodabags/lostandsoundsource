// GENERATED AUTOMATICALLY FROM 'Assets/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""ActionMap"",
            ""id"": ""d9172058-65b4-46c3-bce6-94ba7ead62c4"",
            ""actions"": [
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Value"",
                    ""id"": ""f8c46625-2707-4435-b593-cbeca0692468"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""00e506ab-862f-4e5e-906e-90581d41367c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""69173e0a-994b-47d0-ac6d-d90670ef2046"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Esc"",
                    ""type"": ""Button"",
                    ""id"": ""4c90d2c2-2a77-495c-80e5-b24f6362a955"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""88c3fb6a-4749-4666-bc78-b0fbee967051"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MasterControlScheme"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25d3604b-f537-4665-b5b5-8f66e8d92217"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MasterControlScheme"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b7b2470-cef9-4d06-b186-0fbcc5624c8b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MasterControlScheme"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd1558be-7cc8-44bd-a255-443b9afeab21"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MasterControlScheme"",
                    ""action"": ""Esc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MasterControlScheme"",
            ""bindingGroup"": ""MasterControlScheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // ActionMap
        m_ActionMap = asset.FindActionMap("ActionMap", throwIfNotFound: true);
        m_ActionMap_MoveLeft = m_ActionMap.FindAction("MoveLeft", throwIfNotFound: true);
        m_ActionMap_MoveRight = m_ActionMap.FindAction("MoveRight", throwIfNotFound: true);
        m_ActionMap_Shoot = m_ActionMap.FindAction("Shoot", throwIfNotFound: true);
        m_ActionMap_Esc = m_ActionMap.FindAction("Esc", throwIfNotFound: true);
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

    // ActionMap
    private readonly InputActionMap m_ActionMap;
    private IActionMapActions m_ActionMapActionsCallbackInterface;
    private readonly InputAction m_ActionMap_MoveLeft;
    private readonly InputAction m_ActionMap_MoveRight;
    private readonly InputAction m_ActionMap_Shoot;
    private readonly InputAction m_ActionMap_Esc;
    public struct ActionMapActions
    {
        private @Input m_Wrapper;
        public ActionMapActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLeft => m_Wrapper.m_ActionMap_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_ActionMap_MoveRight;
        public InputAction @Shoot => m_Wrapper.m_ActionMap_Shoot;
        public InputAction @Esc => m_Wrapper.m_ActionMap_Esc;
        public InputActionMap Get() { return m_Wrapper.m_ActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IActionMapActions instance)
        {
            if (m_Wrapper.m_ActionMapActionsCallbackInterface != null)
            {
                @MoveLeft.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMoveRight;
                @Shoot.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnShoot;
                @Esc.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnEsc;
                @Esc.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnEsc;
                @Esc.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnEsc;
            }
            m_Wrapper.m_ActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Esc.started += instance.OnEsc;
                @Esc.performed += instance.OnEsc;
                @Esc.canceled += instance.OnEsc;
            }
        }
    }
    public ActionMapActions @ActionMap => new ActionMapActions(this);
    private int m_MasterControlSchemeSchemeIndex = -1;
    public InputControlScheme MasterControlSchemeScheme
    {
        get
        {
            if (m_MasterControlSchemeSchemeIndex == -1) m_MasterControlSchemeSchemeIndex = asset.FindControlSchemeIndex("MasterControlScheme");
            return asset.controlSchemes[m_MasterControlSchemeSchemeIndex];
        }
    }
    public interface IActionMapActions
    {
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnEsc(InputAction.CallbackContext context);
    }
}
