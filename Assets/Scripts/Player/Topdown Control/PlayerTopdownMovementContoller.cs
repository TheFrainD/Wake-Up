using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopdownMovementContoller : MonoBehaviour
{
    PlayerTopdownController playerController;

    [SerializeField]
    Camera cam;

    float angle = 0.0f;
    
    private Vector2 velocity = Vector2.zero;

    private void Awake()
    {
        playerController = GetComponent<PlayerTopdownController>();
    }

    private void Update() 
    {
        velocity = playerController.playerInput.input.normalized * playerController.playerSpeed;

        playerController.animator.SetFloat("Velocity", playerController.playerInput.input != Vector2.zero && playerController.canMove ? 1 : 0);

        if (playerController.isArmed) {
            playerController.animator.SetBool("isArmed", true);
        }
    }

    private void FixedUpdate() 
    {
        if (playerController.canMove) {
            playerController.rbody.MovePosition(playerController.rbody.position + (Vector2)transform.up * velocity.y * Time.fixedDeltaTime);

            Vector2 lookDir = playerController.playerInput.mousePos - (Vector2)cam.WorldToScreenPoint(playerController.rbody.position);
            angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90.0f;
            playerController.rbody.rotation = angle;
        }
    }
}
