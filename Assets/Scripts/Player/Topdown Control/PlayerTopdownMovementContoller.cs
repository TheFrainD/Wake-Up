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

    private Vector2 CustomRotate(Vector2 vector, float angle) {
        float sin = Mathf.Sin(angle * Mathf.Deg2Rad);
        float cos = Mathf.Cos(angle * Mathf.Deg2Rad);
         
        float tx = vector.x;
        float ty = vector.y;
        vector.x = (cos * tx) - (sin * ty);
        vector.y = (sin * tx) + (cos * ty);
        return vector;
    }

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
        playerController.rbody.MovePosition(playerController.rbody.position + (Vector2)transform.up * velocity.y * Time.fixedDeltaTime);

        Vector2 lookDir = playerController.playerInput.mousePos - (Vector2)cam.WorldToScreenPoint(playerController.rbody.position);
        angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90.0f;
        playerController.rbody.rotation = angle;
    }
}
