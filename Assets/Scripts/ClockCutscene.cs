using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockCutscene : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] PlayerController playerController;
    [SerializeField] TextController textController;

    private float timer = 0.0f;

    private void Start() {
        playerController.canMove = false;
    }

    private void FixedUpdate() {
        timer += Time.fixedDeltaTime;
    }
    
    private void Update() {
        if (timer >= 0.5f && timer <= 1.5f) {
            textController.SetText("Hmm....");
        }

        if (timer > 1.5f && timer <= 3.5f) {
            textController.SetText("I remember leaving ammo for gun");
        }

        if (timer > 3.5f && timer <= 5.5f) {
            textController.SetText("in small niche in clock");
        }

        if (timer > 5.5f && timer <= 7.5f) {
            textController.SetText("I need to come up with a way to open it");
        }

        if (timer > 7.5f && timer <= 7.7f) {
            textController.SetText("");
            playerController.canMove = true;
        }
    }
}
