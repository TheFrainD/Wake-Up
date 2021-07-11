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

    [Header("Sprite Managing")]
    [SerializeField]
    internal Sprite spriteUnarmed;
    [SerializeField]
    internal Sprite spriteArmed;

    internal Rigidbody2D rbody;
    internal SpriteRenderer spriteRenderer;
    [SerializeField]
    internal bool isArmed = false;
    internal bool canMove = true;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start() {
        if (isArmed) {
            spriteRenderer.sprite = spriteArmed;
        }
        transform.position = startingPosition;
    }
}
