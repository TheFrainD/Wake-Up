using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealthCutscene : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] PlayerTopdownController playerController;
    [SerializeField] TextController textController;

    private float timer = 0.0f;

    private void Start() {
        playerController.canMove = false;
    }

    private void FixedUpdate() {
        timer += Time.fixedDeltaTime;
    }
    
    private void Update() {
        if (timer >= 0.5f && timer <= 2.5f) {
            textController.SetText("I must not attract much attention");
        }

        if (timer > 2.5f && timer <= 4.5f) {
            textController.SetText("and sneak around these cars");
        }

        if (timer > 4.5f && timer <= 4.7f) {
            textController.SetText("");
            playerController.canMove = true;
        }
    }
}
