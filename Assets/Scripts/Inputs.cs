// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Inputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Inputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""Hider"",
            ""id"": ""3b8fc6e0-996e-41c0-b54c-6573ebb4dddc"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""4ca3732d-3f2f-43b5-a43d-1e6b6bba5903"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Speak"",
                    ""type"": ""Button"",
                    ""id"": ""3a5960c3-6892-4cbd-a0f7-02feeb038add"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ability"",
                    ""type"": ""Button"",
                    ""id"": ""03061d00-f4e5-4533-9c50-3fb10ba6a8d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fd1d6dbb-fa42-4c49-a284-d4c0a86266bb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""47050aa1-8678-4227-90db-402a3e2ed403"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""61eddc2c-bd38-4da4-9174-c172d7fe6c05"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""414c0868-d9ce-41db-b24b-7b335045afd9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5befa9a2-1397-415b-a2ee-70648df5309f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""da268d14-7ea9-445f-a097-16e7473074c3"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Speak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aff29197-1975-4027-91e1-3994ee41c17a"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ability"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Seeker"",
            ""id"": ""824ca03d-20eb-4e3a-aa1f-2ce7c0ba2a30"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""6b03e66c-772a-4d50-af78-d83014fabc98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Capture"",
                    ""type"": ""Button"",
                    ""id"": ""f0001f53-424b-424c-8df3-7814d6b43640"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ability"",
                    ""type"": ""Button"",
                    ""id"": ""b9b0bb80-1234-4155-b0b1-b04b4ca92f1f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7ebd987a-898c-4e57-a7db-ced8e098e3d8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""00ec1ced-908f-4421-bfae-eaa84cf044dc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""94f6c2e0-e8b2-445d-8975-bc947411ac32"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""00b3a614-4885-4500-b607-ff0de73b09c0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""92bacaa5-7a35-4d57-b85c-a9d60f60e8d3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""75f24f3a-e148-4787-b7a6-e5480a6e76e7"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Capture"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76269253-0467-4c18-aa41-6d1714a8acb5"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ability"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Hider
        m_Hider = asset.FindActionMap("Hider", throwIfNotFound: true);
        m_Hider_Movement = m_Hider.FindAction("Movement", throwIfNotFound: true);
        m_Hider_Speak = m_Hider.FindAction("Speak", throwIfNotFound: true);
        m_Hider_Ability = m_Hider.FindAction("Ability", throwIfNotFound: true);
        // Seeker
        m_Seeker = asset.FindActionMap("Seeker", throwIfNotFound: true);
        m_Seeker_Movement = m_Seeker.FindAction("Movement", throwIfNotFound: true);
        m_Seeker_Capture = m_Seeker.FindAction("Capture", throwIfNotFound: true);
        m_Seeker_Ability = m_Seeker.FindAction("Ability", throwIfNotFound: true);
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

    // Hider
    private readonly InputActionMap m_Hider;
    private IHiderActions m_HiderActionsCallbackInterface;
    private readonly InputAction m_Hider_Movement;
    private readonly InputAction m_Hider_Speak;
    private readonly InputAction m_Hider_Ability;
    public struct HiderActions
    {
        private @Inputs m_Wrapper;
        public HiderActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Hider_Movement;
        public InputAction @Speak => m_Wrapper.m_Hider_Speak;
        public InputAction @Ability => m_Wrapper.m_Hider_Ability;
        public InputActionMap Get() { return m_Wrapper.m_Hider; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HiderActions set) { return set.Get(); }
        public void SetCallbacks(IHiderActions instance)
        {
            if (m_Wrapper.m_HiderActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_HiderActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_HiderActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_HiderActionsCallbackInterface.OnMovement;
                @Speak.started -= m_Wrapper.m_HiderActionsCallbackInterface.OnSpeak;
                @Speak.performed -= m_Wrapper.m_HiderActionsCallbackInterface.OnSpeak;
                @Speak.canceled -= m_Wrapper.m_HiderActionsCallbackInterface.OnSpeak;
                @Ability.started -= m_Wrapper.m_HiderActionsCallbackInterface.OnAbility;
                @Ability.performed -= m_Wrapper.m_HiderActionsCallbackInterface.OnAbility;
                @Ability.canceled -= m_Wrapper.m_HiderActionsCallbackInterface.OnAbility;
            }
            m_Wrapper.m_HiderActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Speak.started += instance.OnSpeak;
                @Speak.performed += instance.OnSpeak;
                @Speak.canceled += instance.OnSpeak;
                @Ability.started += instance.OnAbility;
                @Ability.performed += instance.OnAbility;
                @Ability.canceled += instance.OnAbility;
            }
        }
    }
    public HiderActions @Hider => new HiderActions(this);

    // Seeker
    private readonly InputActionMap m_Seeker;
    private ISeekerActions m_SeekerActionsCallbackInterface;
    private readonly InputAction m_Seeker_Movement;
    private readonly InputAction m_Seeker_Capture;
    private readonly InputAction m_Seeker_Ability;
    public struct SeekerActions
    {
        private @Inputs m_Wrapper;
        public SeekerActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Seeker_Movement;
        public InputAction @Capture => m_Wrapper.m_Seeker_Capture;
        public InputAction @Ability => m_Wrapper.m_Seeker_Ability;
        public InputActionMap Get() { return m_Wrapper.m_Seeker; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SeekerActions set) { return set.Get(); }
        public void SetCallbacks(ISeekerActions instance)
        {
            if (m_Wrapper.m_SeekerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_SeekerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_SeekerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_SeekerActionsCallbackInterface.OnMovement;
                @Capture.started -= m_Wrapper.m_SeekerActionsCallbackInterface.OnCapture;
                @Capture.performed -= m_Wrapper.m_SeekerActionsCallbackInterface.OnCapture;
                @Capture.canceled -= m_Wrapper.m_SeekerActionsCallbackInterface.OnCapture;
                @Ability.started -= m_Wrapper.m_SeekerActionsCallbackInterface.OnAbility;
                @Ability.performed -= m_Wrapper.m_SeekerActionsCallbackInterface.OnAbility;
                @Ability.canceled -= m_Wrapper.m_SeekerActionsCallbackInterface.OnAbility;
            }
            m_Wrapper.m_SeekerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Capture.started += instance.OnCapture;
                @Capture.performed += instance.OnCapture;
                @Capture.canceled += instance.OnCapture;
                @Ability.started += instance.OnAbility;
                @Ability.performed += instance.OnAbility;
                @Ability.canceled += instance.OnAbility;
            }
        }
    }
    public SeekerActions @Seeker => new SeekerActions(this);
    public interface IHiderActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnSpeak(InputAction.CallbackContext context);
        void OnAbility(InputAction.CallbackContext context);
    }
    public interface ISeekerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCapture(InputAction.CallbackContext context);
        void OnAbility(InputAction.CallbackContext context);
    }
}
