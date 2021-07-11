using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomCutscene : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] PlayerController playerController;
    [SerializeField] TextController textController;

    private float timer = 0.0f;

    private void Start() {
        playerController.canMove = false;
    }

    private void Update() {
        if (timer >= 0.5f && timer <= 3.0f) {
            playerController.rbody.MovePosition(playerController.rbody.position - (Vector2)player.transform.right * playerController.playerSpeed * Time.deltaTime);
        }

        if (timer >= 2.0f && timer < 5.0f) {
            textController.SetText("What is happening?! Is that me?!");
        }

        if (timer >= 5.0f && timer < 8.0f) {
            textController.SetText("How is this possible?");
        }

        if (timer >= 8.0f && timer < 11.0f) {
            textController.SetText("I have to wake myself up somehow");
        }
        
        if (timer >= 11.0f && timer <= 11.2f) {
            textController.SetText("");
            playerController.canMove = true;
        }
    }

    private void FixedUpdate() {
        timer += Time.fixedDeltaTime;
    }
}
