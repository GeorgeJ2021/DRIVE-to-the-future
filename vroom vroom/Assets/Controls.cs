// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Car"",
            ""id"": ""e22ac339-97ea-4540-aa4c-4f834e8d70f9"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""3e97b9fd-f7ba-4a0c-b105-b42fef7157a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SteerRight"",
                    ""type"": ""Button"",
                    ""id"": ""fa3a6c84-901d-4d95-aeeb-cdebe942807e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SteerLeft"",
                    ""type"": ""Button"",
                    ""id"": ""884cbaf9-c026-48c0-ad97-5cb9ac3e45d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""721c0bee-cb04-4df0-bd80-3c487b632256"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""641fd29a-629a-4efe-be0a-0c4b3aee6651"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SteerRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd65e17d-bba2-4504-846e-ad84f7aafb79"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SteerLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Car
        m_Car = asset.FindActionMap("Car", throwIfNotFound: true);
        m_Car_Accelerate = m_Car.FindAction("Accelerate", throwIfNotFound: true);
        m_Car_SteerRight = m_Car.FindAction("SteerRight", throwIfNotFound: true);
        m_Car_SteerLeft = m_Car.FindAction("SteerLeft", throwIfNotFound: true);
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

    // Car
    private readonly InputActionMap m_Car;
    private ICarActions m_CarActionsCallbackInterface;
    private readonly InputAction m_Car_Accelerate;
    private readonly InputAction m_Car_SteerRight;
    private readonly InputAction m_Car_SteerLeft;
    public struct CarActions
    {
        private @Controls m_Wrapper;
        public CarActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_Car_Accelerate;
        public InputAction @SteerRight => m_Wrapper.m_Car_SteerRight;
        public InputAction @SteerLeft => m_Wrapper.m_Car_SteerLeft;
        public InputActionMap Get() { return m_Wrapper.m_Car; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CarActions set) { return set.Get(); }
        public void SetCallbacks(ICarActions instance)
        {
            if (m_Wrapper.m_CarActionsCallbackInterface != null)
            {
                @Accelerate.started -= m_Wrapper.m_CarActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnAccelerate;
                @SteerRight.started -= m_Wrapper.m_CarActionsCallbackInterface.OnSteerRight;
                @SteerRight.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnSteerRight;
                @SteerRight.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnSteerRight;
                @SteerLeft.started -= m_Wrapper.m_CarActionsCallbackInterface.OnSteerLeft;
                @SteerLeft.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnSteerLeft;
                @SteerLeft.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnSteerLeft;
            }
            m_Wrapper.m_CarActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @SteerRight.started += instance.OnSteerRight;
                @SteerRight.performed += instance.OnSteerRight;
                @SteerRight.canceled += instance.OnSteerRight;
                @SteerLeft.started += instance.OnSteerLeft;
                @SteerLeft.performed += instance.OnSteerLeft;
                @SteerLeft.canceled += instance.OnSteerLeft;
            }
        }
    }
    public CarActions @Car => new CarActions(this);
    public interface ICarActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnSteerRight(InputAction.CallbackContext context);
        void OnSteerLeft(InputAction.CallbackContext context);
    }
}
