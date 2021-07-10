using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    internal Vector2 input = Vector2.zero;
    internal Vector2 mousePos = Vector2.zero;
    internal bool isJumpPressed = false;

    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        isJumpPressed = Input.GetButton("Jump");
        mousePos = Input.mousePosition;
    }
}
