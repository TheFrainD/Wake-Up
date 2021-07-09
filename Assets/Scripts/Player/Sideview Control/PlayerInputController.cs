using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    internal PlayerController playerController;

    internal Vector2 input = Vector2.zero;
    internal bool isJumpPressed = false;

    void Awake()
    {
        playerController = GetComponent<PlayerController>();
    }

    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        isJumpPressed = Input.GetButton("Jump");
    }
}
