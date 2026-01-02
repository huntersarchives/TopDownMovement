using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    public Vector2 movement;

    [SerializeField] private Rigidbody2D rb;


    // Update is called once per frame
    void Update()
    {
        movement.Set(InputManager.movement.x, InputManager.movement.y);

        rb.linearVelocity = movement * moveSpeed;
    }
}
