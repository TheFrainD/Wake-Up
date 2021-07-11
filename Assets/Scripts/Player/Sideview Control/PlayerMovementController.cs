using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    PlayerController playerController;
   
    [Header("Ground Checking")]
    [SerializeField]
    private Transform groundChecker;
    [SerializeField]
    private LayerMask groundLayer;

    private bool isGrounded = false;
    private const float groundCheckRadius = 0.2f;

    private float moveBy = 0.0f;
    private Vector2 targetVelocity = Vector2.zero;
    private Vector2 currentVelocity = Vector2.zero;
    private bool isFacingRight = false;

    void Awake()
    {
        playerController = GetComponent<PlayerController>();
    }

    void Start()
    {
        playerController.rbody.velocity = Vector2.zero;
    }

    void FixedUpdate()
    {
        // Check ground
        isGrounded = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundChecker.position, groundCheckRadius, groundLayer);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                isGrounded = true;
            }
        }

        Move();
    }

    void Update()
    {
        if (playerController.canMove) {
            moveBy = playerController.playerInput.input.x * playerController.playerSpeed;
            targetVelocity = new Vector2(moveBy, playerController.rbody.velocity.y);

            if (isGrounded) {
                playerController.animator.SetFloat("Velocity", Mathf.Abs(playerController.playerInput.input.x));
            } else {
                playerController.animator.SetFloat("Velocity", 0.0f);
            }

            // Flip sprite
            if ((moveBy > 0 && !isFacingRight) || (moveBy < 0 && isFacingRight))
            {
                Flip();
            }

            if (playerController.playerInput.isJumpPressed)
            {
                Jump();
            }

            //Jump
            if (playerController.rbody.velocity.y < 0)
            {
                playerController.rbody.velocity += Vector2.up * Physics2D.gravity.y * (playerController.fallFactor - 1) * Time.deltaTime;
            }
            else if (playerController.rbody.velocity.y > 0 && !playerController.playerInput.isJumpPressed)
            {
                playerController.rbody.velocity += Vector2.up * Physics2D.gravity.y * (playerController.lowJumpFactor - 1) * Time.deltaTime;
            }
        } else {
            playerController.rbody.velocity = Vector2.zero;
        }
    }

    private void Move()
    {
        if (playerController.canMove) {
            playerController.rbody.velocity = Vector2.SmoothDamp(playerController.rbody.velocity, targetVelocity,
                ref currentVelocity, playerController.movementSmoothing);
        }
    }

    private void Jump()
    {
        if (isGrounded)
        {
            playerController.rbody.AddForce(new Vector2(0.0f, playerController.jumpVelocity));
            isGrounded = false;
        }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
