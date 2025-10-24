using FishNet;
using FishNet.Object;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBoardMovement : NetworkBehaviour
{
    public float moveSpeed = 5f;

    private PlayerInputs inputs;
    private InputAction move;

    [SerializeField] private Rigidbody2D rb;

    private bool canMove = true;

    private void Awake()
    {
        inputs = new PlayerInputs();
    }

    public override void OnStartClient()
    {
        if (!IsOwner) return;

        inputs.InLobby.Enable();
        move = inputs.InLobby.Move;
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    void FixedUpdate()
    {
        if (!IsOwner)
            return;

        if (canMove)
        {
            rb.linearVelocity = (move.ReadValue<Vector2>() * moveSpeed);
        }
    }
}
