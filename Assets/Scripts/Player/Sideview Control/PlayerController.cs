using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Scripts")]
    [SerializeField]
    internal PlayerInputController playerInput;
    [SerializeField]
    internal PlayerMovementController playerMovement;

    [Header("Movement")]
    [SerializeField]
    internal float playerSpeed = 5.0f;
    [SerializeField]
    internal float movementSmoothing = 0.05f;

    [Header("Jumping")]
    [SerializeField]
    internal float jumpVelocity = 15.0f;
    [SerializeField]
    internal float fallFactor = 2.5f;
    [SerializeField]
    internal float lowJumpFactor = 2.0f;

    internal Rigidbody2D rbody;
    internal bool canMove = true;
    internal Animator animator;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
}
