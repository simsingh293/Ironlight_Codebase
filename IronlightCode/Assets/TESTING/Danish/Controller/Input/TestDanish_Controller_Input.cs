// GENERATED AUTOMATICALLY FROM 'Assets/TESTING/Danish/Controller/Input/TestDanish_Controller_Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TestDanish_Controller_Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TestDanish_Controller_Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TestDanish_Controller_Input"",
    ""maps"": [
        {
            ""name"": ""Traversal"",
            ""id"": ""5432049c-a8c6-464e-a6c7-9c61e25b44a0"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c138788f-f399-43ef-9fe5-fcc27529e108"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8230ee4b-40b2-4bf8-a4c0-3a9f68602d60"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""bf93ff86-3acd-4247-b4ba-6a0d675081e2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ADS"",
                    ""type"": ""Button"",
                    ""id"": ""9e4e5092-bb3b-4d5b-a2e3-6992b44cc39e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""773ca573-5e69-44d7-931e-7351e8edf2c5"",
                    ""path"": ""2DVector(normalize=false)"",
                    ""interactions"": ""Hold(duration=0.01),Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4ccc9810-6d59-4c2d-bc1d-5866d9e9e4eb"",
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
                    ""id"": ""92c563b4-e5c2-42b2-b631-8f67b041352f"",
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
                    ""id"": ""0ebc77cf-56c1-41c7-b3e6-e2ef79e638f2"",
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
                    ""id"": ""029ba5e1-8eb6-4b2f-957a-78da1b2069e1"",
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
                    ""id"": ""53f9f5c7-c54e-4b1d-8214-614e41495ddd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ddcfa448-6cc9-4891-a04f-43fcc1a5929e"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""575241ad-c9cb-495b-8619-75c8cae779d1"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ADS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Combat"",
            ""id"": ""4533a6a6-403a-4bd5-b3a5-65f5f3daedff"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""951ef509-b195-4bd1-adbc-7ad5851968a8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""OrbTest"",
                    ""type"": ""Button"",
                    ""id"": ""8e0ea812-aa0f-4475-a9a4-e5ed9bdf73aa"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BeamTest"",
                    ""type"": ""Button"",
                    ""id"": ""af6eb16e-077d-4a4e-ad50-f53901441795"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BlastTest"",
                    ""type"": ""Button"",
                    ""id"": ""0a8a575e-244c-4ac9-ac94-e0ec41045968"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f899aac0-b295-444e-a677-ac622bb7faac"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5bf2e27-170e-4a99-9b94-ca4ee32b037b"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OrbTest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eecc40b5-8913-412b-beec-c30489e9d117"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BeamTest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6fcb9edb-bd00-408a-9b3e-fa84c9884f2a"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": ""Hold(duration=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BlastTest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interaction"",
            ""id"": ""a429d3df-0a5a-4e13-b1b5-0d6f8ded2a25"",
            ""actions"": [
                {
                    ""name"": ""CrystalInteract"",
                    ""type"": ""Button"",
                    ""id"": ""8a566531-f12e-43f7-8494-ba824346d38e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""PowerScroll"",
                    ""type"": ""Value"",
                    ""id"": ""9c1c905a-5311-4e49-af0c-76a35b99b885"",
                    ""expectedControlType"": ""Double"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cd13add6-adbb-4576-828a-580533be5970"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CrystalInteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6833da8c-26fc-4081-9220-dd7c0e0b1b10"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Traversal
        m_Traversal = asset.FindActionMap("Traversal", throwIfNotFound: true);
        m_Traversal_Movement = m_Traversal.FindAction("Movement", throwIfNotFound: true);
        m_Traversal_Jump = m_Traversal.FindAction("Jump", throwIfNotFound: true);
        m_Traversal_Dash = m_Traversal.FindAction("Dash", throwIfNotFound: true);
        m_Traversal_ADS = m_Traversal.FindAction("ADS", throwIfNotFound: true);
        // Combat
        m_Combat = asset.FindActionMap("Combat", throwIfNotFound: true);
        m_Combat_Attack = m_Combat.FindAction("Attack", throwIfNotFound: true);
        m_Combat_OrbTest = m_Combat.FindAction("OrbTest", throwIfNotFound: true);
        m_Combat_BeamTest = m_Combat.FindAction("BeamTest", throwIfNotFound: true);
        m_Combat_BlastTest = m_Combat.FindAction("BlastTest", throwIfNotFound: true);
        // Interaction
        m_Interaction = asset.FindActionMap("Interaction", throwIfNotFound: true);
        m_Interaction_CrystalInteract = m_Interaction.FindAction("CrystalInteract", throwIfNotFound: true);
        m_Interaction_PowerScroll = m_Interaction.FindAction("PowerScroll", throwIfNotFound: true);
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

    // Traversal
    private readonly InputActionMap m_Traversal;
    private ITraversalActions m_TraversalActionsCallbackInterface;
    private readonly InputAction m_Traversal_Movement;
    private readonly InputAction m_Traversal_Jump;
    private readonly InputAction m_Traversal_Dash;
    private readonly InputAction m_Traversal_ADS;
    public struct TraversalActions
    {
        private @TestDanish_Controller_Input m_Wrapper;
        public TraversalActions(@TestDanish_Controller_Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Traversal_Movement;
        public InputAction @Jump => m_Wrapper.m_Traversal_Jump;
        public InputAction @Dash => m_Wrapper.m_Traversal_Dash;
        public InputAction @ADS => m_Wrapper.m_Traversal_ADS;
        public InputActionMap Get() { return m_Wrapper.m_Traversal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TraversalActions set) { return set.Get(); }
        public void SetCallbacks(ITraversalActions instance)
        {
            if (m_Wrapper.m_TraversalActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_TraversalActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_TraversalActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_TraversalActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_TraversalActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_TraversalActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_TraversalActionsCallbackInterface.OnJump;
                @Dash.started -= m_Wrapper.m_TraversalActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_TraversalActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_TraversalActionsCallbackInterface.OnDash;
                @ADS.started -= m_Wrapper.m_TraversalActionsCallbackInterface.OnADS;
                @ADS.performed -= m_Wrapper.m_TraversalActionsCallbackInterface.OnADS;
                @ADS.canceled -= m_Wrapper.m_TraversalActionsCallbackInterface.OnADS;
            }
            m_Wrapper.m_TraversalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @ADS.started += instance.OnADS;
                @ADS.performed += instance.OnADS;
                @ADS.canceled += instance.OnADS;
            }
        }
    }
    public TraversalActions @Traversal => new TraversalActions(this);

    // Combat
    private readonly InputActionMap m_Combat;
    private ICombatActions m_CombatActionsCallbackInterface;
    private readonly InputAction m_Combat_Attack;
    private readonly InputAction m_Combat_OrbTest;
    private readonly InputAction m_Combat_BeamTest;
    private readonly InputAction m_Combat_BlastTest;
    public struct CombatActions
    {
        private @TestDanish_Controller_Input m_Wrapper;
        public CombatActions(@TestDanish_Controller_Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_Combat_Attack;
        public InputAction @OrbTest => m_Wrapper.m_Combat_OrbTest;
        public InputAction @BeamTest => m_Wrapper.m_Combat_BeamTest;
        public InputAction @BlastTest => m_Wrapper.m_Combat_BlastTest;
        public InputActionMap Get() { return m_Wrapper.m_Combat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombatActions set) { return set.Get(); }
        public void SetCallbacks(ICombatActions instance)
        {
            if (m_Wrapper.m_CombatActionsCallbackInterface != null)
            {
                @Attack.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack;
                @OrbTest.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnOrbTest;
                @OrbTest.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnOrbTest;
                @OrbTest.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnOrbTest;
                @BeamTest.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnBeamTest;
                @BeamTest.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnBeamTest;
                @BeamTest.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnBeamTest;
                @BlastTest.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnBlastTest;
                @BlastTest.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnBlastTest;
                @BlastTest.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnBlastTest;
            }
            m_Wrapper.m_CombatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @OrbTest.started += instance.OnOrbTest;
                @OrbTest.performed += instance.OnOrbTest;
                @OrbTest.canceled += instance.OnOrbTest;
                @BeamTest.started += instance.OnBeamTest;
                @BeamTest.performed += instance.OnBeamTest;
                @BeamTest.canceled += instance.OnBeamTest;
                @BlastTest.started += instance.OnBlastTest;
                @BlastTest.performed += instance.OnBlastTest;
                @BlastTest.canceled += instance.OnBlastTest;
            }
        }
    }
    public CombatActions @Combat => new CombatActions(this);

    // Interaction
    private readonly InputActionMap m_Interaction;
    private IInteractionActions m_InteractionActionsCallbackInterface;
    private readonly InputAction m_Interaction_CrystalInteract;
    private readonly InputAction m_Interaction_PowerScroll;
    public struct InteractionActions
    {
        private @TestDanish_Controller_Input m_Wrapper;
        public InteractionActions(@TestDanish_Controller_Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @CrystalInteract => m_Wrapper.m_Interaction_CrystalInteract;
        public InputAction @PowerScroll => m_Wrapper.m_Interaction_PowerScroll;
        public InputActionMap Get() { return m_Wrapper.m_Interaction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionActions set) { return set.Get(); }
        public void SetCallbacks(IInteractionActions instance)
        {
            if (m_Wrapper.m_InteractionActionsCallbackInterface != null)
            {
                @CrystalInteract.started -= m_Wrapper.m_InteractionActionsCallbackInterface.OnCrystalInteract;
                @CrystalInteract.performed -= m_Wrapper.m_InteractionActionsCallbackInterface.OnCrystalInteract;
                @CrystalInteract.canceled -= m_Wrapper.m_InteractionActionsCallbackInterface.OnCrystalInteract;
                @PowerScroll.started -= m_Wrapper.m_InteractionActionsCallbackInterface.OnPowerScroll;
                @PowerScroll.performed -= m_Wrapper.m_InteractionActionsCallbackInterface.OnPowerScroll;
                @PowerScroll.canceled -= m_Wrapper.m_InteractionActionsCallbackInterface.OnPowerScroll;
            }
            m_Wrapper.m_InteractionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CrystalInteract.started += instance.OnCrystalInteract;
                @CrystalInteract.performed += instance.OnCrystalInteract;
                @CrystalInteract.canceled += instance.OnCrystalInteract;
                @PowerScroll.started += instance.OnPowerScroll;
                @PowerScroll.performed += instance.OnPowerScroll;
                @PowerScroll.canceled += instance.OnPowerScroll;
            }
        }
    }
    public InteractionActions @Interaction => new InteractionActions(this);
    public interface ITraversalActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnADS(InputAction.CallbackContext context);
    }
    public interface ICombatActions
    {
        void OnAttack(InputAction.CallbackContext context);
        void OnOrbTest(InputAction.CallbackContext context);
        void OnBeamTest(InputAction.CallbackContext context);
        void OnBlastTest(InputAction.CallbackContext context);
    }
    public interface IInteractionActions
    {
        void OnCrystalInteract(InputAction.CallbackContext context);
        void OnPowerScroll(InputAction.CallbackContext context);
    }
}
