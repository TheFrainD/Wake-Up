using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCutscene : MonoBehaviour
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
            textController.SetText("At night room is full of monsters...");
        }

        if (timer > 2.5f && timer <= 4.5f) {
            textController.SetText("I have to find the gun I left here");
        }

        if (timer > 4.5f && timer <= 4.7f) {
            textController.SetText("");
            playerController.canMove = true;
        }
    }
}
