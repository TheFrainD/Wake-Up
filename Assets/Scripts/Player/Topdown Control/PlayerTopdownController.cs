using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopdownController : MonoBehaviour
{
    [Header("Player Scripts")]
    [SerializeField]
    internal PlayerInputController playerInput;
    [SerializeField]
    internal PlayerTopdownMovementContoller playerMovement;
    [SerializeField]
    internal PlayerTopdownCollisionController playerCollision;

    [Header("Movement")]
    [SerializeField]
    internal Vector3 startingPosition;
    [SerializeField]
    internal float playerSpeed = 5.0f;

    internal Rigidbody2D rbody;
    internal Animator animator;
    [SerializeField]
    internal bool isArmed = false;
    internal bool canMove = true;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Start() {
        transform.position = startingPosition;
    }
}
