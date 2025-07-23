using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// This script controls the Player and handles Inputs, transfers these to the State Machine
/// Think about adding requirements here
/// </summary>
public class PlayerController : MonoBehaviour
{
    // Singleton
    public static PlayerController Instance;

    #region Unity Exposed Fields
    // References to set in Inspector for clarity, will be automated later if possible or necessary
    [Header("References")]
    [SerializeField] private GameObject playerObject;
    [SerializeField] private Transform playerTransform; // reference to PlayerPosition, Rigidbody will probably replace this
    [SerializeField] private Camera playerCamera; // reference to camera in Player Object
    [SerializeField] private Input playerInput; // Reference to player InputSystem
    [SerializeField] private PlayerStateMachine playerStateMachine; // Reference the StateMachine Object
    [SerializeField] private Animator playerAnimator; // maybe better in StateMachine, Player Inputs don#t control these
    #region Properties
    // Player properties 
    [Header("Player Properties")]
    [SerializeField][Range(0, 100f)] private float accelerationForce;
    [SerializeField][Range(0, 100f)] private float decelerationForce;
    [SerializeField][Range(0, 100f)] private float jumpForce;
    [SerializeField][Range(0, 100f)] private float hoverForce;
    #endregion

    #endregion

    #region Unity Engine Exposed Field Derived
    // Derived fields

    #endregion

    #region Fields

    #endregion


    #region Variables
    // All relevant Variables we need for this script only
    #endregion

    #region Public Getters
    // to communicate between other scripts and provide information

    #endregion

    #region Monobehaviour Methods
    /// <summary>
    /// All methods required to ready the PlayerControls before the game starts properly and Update()
    /// </summary>

    // Awake is called before Start
    private void Awake()
    {
        // Instantiate the playerObject and ready for other components
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get References of instantiated Components required for this script
        // Subscribe Input Actions on Game Start, maybe outsource specific actions and assume to Pause the player if we start in the Main Menu
        // Ensure the player is noth stuck in any other gameObject
        // Player hovers above ground, according to the hoverForce
    }

    #endregion

    #region Control Methods
    private void PlayerMovement()
    {
        // Read Input
        // Move player on hoverboard
        // Controls to steer left and right
        // Controls to accelerate and decelerate

    }

    private void PlayerJump()
    {
        // Read Input
        // Boost the hoverboard upwards
        // Maybe rewrite this into a sort of Boost System of the hoverboard and regulate it with an energy system.
        
    }
    #endregion

    #region Helper Methods

    #endregion

    // Update is called once per frame
    void Update()
    {
        
    }
}
