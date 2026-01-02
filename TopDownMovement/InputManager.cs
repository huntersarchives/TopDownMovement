using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static Vector2 movement;

    private PlayerInput playerInput;

    private InputAction inputAction;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();

        inputAction = playerInput.actions["Move"];
    }

    // Update is called once per frame
    void Update()
    {
        movement = inputAction.ReadValue<Vector2>();    
    }
}
