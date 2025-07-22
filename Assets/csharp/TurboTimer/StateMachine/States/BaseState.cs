using UnityEngine;

public abstract class BaseState
{
    // Maybe transport Input reads and variables to distribute load of responsibility and establish a lean, clean code structure within the states
    // Maybe switch to virtual void if it serves a purpose
    protected virtual void OnEnter() { } // Anything a state needs once the player enters this state, will probably be something every state will call upon
    protected abstract void Update(); // Calling on Update of the state for continous Reads or Controls
    protected abstract void FixedUpdate(); // Calling on anything related to physics
    protected virtual void OnExit() { } // Anything a state needs to achieve once the player exits the state, will probably have some common settings
}