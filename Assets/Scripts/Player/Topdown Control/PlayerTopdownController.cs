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

    [Header("Movement")]
    [SerializeField]
    internal float playerSpeed = 5.0f;

    internal Rigidbody2D rbody;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
}
