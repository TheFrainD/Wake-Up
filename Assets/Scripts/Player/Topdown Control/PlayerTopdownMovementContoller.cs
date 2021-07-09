using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopdownMovementContoller : MonoBehaviour
{
    PlayerTopdownController playerController;
    
    private Vector2 velocity = Vector2.zero;

    private void Awake()
    {
        playerController = GetComponent<PlayerTopdownController>();
    }

    private void Update() 
    {
        velocity = playerController.playerInput.input.normalized * playerController.playerSpeed;
    }

    private void FixedUpdate() 
    {
        playerController.rbody.velocity = velocity;
    }
}
