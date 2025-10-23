using FishNet;
using FishNet.Object;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBoardMovement : NetworkBehaviour
{
    public float moveSpeed = 5f;

    private PlayerInputs inputs;
    private InputAction move;

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

    void Update()
    {
        if (!IsOwner)
            return;


    }
}
