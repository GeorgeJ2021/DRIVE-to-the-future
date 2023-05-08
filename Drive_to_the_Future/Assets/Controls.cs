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
                },
                {
                    ""name"": ""Deaccelerate"",
                    ""type"": ""Button"",
                    ""id"": ""c3bb1aee-a53c-4585-ac09-df8907bead52"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Handbrake"",
                    ""type"": ""Button"",
                    ""id"": ""2a39ddf6-7cf5-431e-b534-cc0d65a5e36a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HorizontalRot"",
                    ""type"": ""Value"",
                    ""id"": ""f51cd625-1612-457e-b9d5-d75a257f1216"",
                    ""expectedControlType"": """",
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
                },
                {
                    ""name"": """",
                    ""id"": ""c54d0e8d-09e9-42a2-bb75-65d867131cd9"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deaccelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1bd64f7d-58c8-4620-a1af-abd606d8ba69"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94d56526-6379-4993-b91a-8e809778477c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalRot"",
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
        m_Car_Deaccelerate = m_Car.FindAction("Deaccelerate", throwIfNotFound: true);
        m_Car_Handbrake = m_Car.FindAction("Handbrake", throwIfNotFound: true);
        m_Car_HorizontalRot = m_Car.FindAction("HorizontalRot", throwIfNotFound: true);
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
    private readonly InputAction m_Car_Deaccelerate;
    private readonly InputAction m_Car_Handbrake;
    private readonly InputAction m_Car_HorizontalRot;
    public struct CarActions
    {
        private @Controls m_Wrapper;
        public CarActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_Car_Accelerate;
        public InputAction @SteerRight => m_Wrapper.m_Car_SteerRight;
        public InputAction @SteerLeft => m_Wrapper.m_Car_SteerLeft;
        public InputAction @Deaccelerate => m_Wrapper.m_Car_Deaccelerate;
        public InputAction @Handbrake => m_Wrapper.m_Car_Handbrake;
        public InputAction @HorizontalRot => m_Wrapper.m_Car_HorizontalRot;
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
                @Deaccelerate.started -= m_Wrapper.m_CarActionsCallbackInterface.OnDeaccelerate;
                @Deaccelerate.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnDeaccelerate;
                @Deaccelerate.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnDeaccelerate;
                @Handbrake.started -= m_Wrapper.m_CarActionsCallbackInterface.OnHandbrake;
                @Handbrake.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnHandbrake;
                @Handbrake.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnHandbrake;
                @HorizontalRot.started -= m_Wrapper.m_CarActionsCallbackInterface.OnHorizontalRot;
                @HorizontalRot.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnHorizontalRot;
                @HorizontalRot.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnHorizontalRot;
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
                @Deaccelerate.started += instance.OnDeaccelerate;
                @Deaccelerate.performed += instance.OnDeaccelerate;
                @Deaccelerate.canceled += instance.OnDeaccelerate;
                @Handbrake.started += instance.OnHandbrake;
                @Handbrake.performed += instance.OnHandbrake;
                @Handbrake.canceled += instance.OnHandbrake;
                @HorizontalRot.started += instance.OnHorizontalRot;
                @HorizontalRot.performed += instance.OnHorizontalRot;
                @HorizontalRot.canceled += instance.OnHorizontalRot;
            }
        }
    }
    public CarActions @Car => new CarActions(this);
    public interface ICarActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnSteerRight(InputAction.CallbackContext context);
        void OnSteerLeft(InputAction.CallbackContext context);
        void OnDeaccelerate(InputAction.CallbackContext context);
        void OnHandbrake(InputAction.CallbackContext context);
        void OnHorizontalRot(InputAction.CallbackContext context);
    }
}
