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
    internal float playerSpeed = 5.0f;

    [Header("Sprite Managing")]
    [SerializeField]
    internal Sprite spriteUnarmed;
    [SerializeField]
    internal Sprite spriteArmed;

    internal Rigidbody2D rbody;
    internal SpriteRenderer spriteRenderer;
    internal bool isArmed = false;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
