using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// This script is the StateMachine, for now it will be designed for the player only
/// Use a Singleton pattern for this
/// This Script should handle StateTransitions. Think about outsourcing responsibilites and workload if it becomes too big
/// </summary>
public class PlayerStateMachine : MonoBehaviour
{
    /// <summary>
    /// References to connect this state machine to the player
    /// </summary>
    
    // Singleton
    public static PlayerStateMachine Instance;

    #region Unity Exposed Fields
    [Header("References")]
    
    [SerializeField] private GameObject player;
    [SerializeField] private
    #endregion

    #region Initialization
    void Awake()
    {

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    #endregion

    // Update is called once per frame
    void Update()
    {
        
    }
}
