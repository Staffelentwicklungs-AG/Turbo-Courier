using UnityEngine;

/// <summary>
/// This script holds information about this player for other scripts to access the information as needed and keep other modules clean or responsibilites
/// </summary>
public class PlayerStats : MonoBehaviour
{
    // Singleton
    public static PlayerStats Instance;
    #region Unity Exposed Fields
    #region References
    [Header("Administrative")]
    [SerializeField] private GameObject playerObject; // reference to PlayerObject itself
    [SerializeField] private Transform playerTransform; // reference to PlayerPosition, Rigidbody will probably replace this
    [SerializeField] private Camera playerCamera; // reference to camera in Player Object

    // Thinking about to use diffrent cameras and leave it up to the player or certain parameters for the control. 
    // For example a camera to follow the player and convey the view and feeling of a racing game
    // And another for precise control to interact with the environment or just to look around, that decides that the contols and orientation of the player 
    // is controlled via the orientation of the hoverboard. Antoher iea in general were different stances

    [SerializeField] private Input playerInput; // Reference to player InputSystem
    [SerializeField] private PlayerStateMachine playerStateMachine; // Reference the StateMachine Object
 //   [SerializeField] private InteractionManager interactionManager; yet to be implemented if ever
    
    [SerializeField] private Animator playerAnimator; // maybe better in StateMachine, Player Inputs don't control these
    #endregion

    #region Variables/Properties
    /// <summary>
    /// Holds the player properties which define the capabilities of the character These are set to create a baseline for the developer to work with
    /// The Variables are supposed to just hold information, maybe these are entirely redundant at this point in the script and should be in Public Getters
    /// Or i just don't care about these redundancies at development stage unti lwe know what exactly to do with it
    /// </summary>
    [Header("Player Properties")]
    [SerializeField]
    [Range(0, 100f)] private float acceleration; // Force that is applied when the character moves about
    [SerializeField]
    [Range(0, 100f)] private float deceleration; // Force that is applied when the player actively brakes
    [SerializeField]
    [Range(0, 100f)] private float jumpForce; // Subject to change if we need a higher force
    [SerializeField]
    [Range(0, 100f)] private float boostForce; // To boost the player movement
    [SerializeField]
    [Range(0, 100f)] private float hoverForce; // To apply force whenever the hoverboard is below a certain threshhold


    
    #endregion

    #region Stats

    #endregion
    #endregion

    #region Public Getters

    #endregion
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
