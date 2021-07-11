using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTopdownCollisionController : MonoBehaviour
{
    PlayerTopdownController playerController;
    TextController textController;

    private float cullDown = 0.0f;

    private void FixedUpdate() {
        if (cullDown >= 0.0f) {
            cullDown -= Time.fixedDeltaTime;
        }
    }

    private void Awake() {
        playerController = GetComponent<PlayerTopdownController>();
        textController = GetComponent<TextController>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.name == "Gun") {
            playerController.isArmed = true;

            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "Maze Portal") {
            if (playerController.isArmed) {
                SceneManager.LoadScene("Stealth Level");
            } else if (cullDown <= 0.0f) {
                textController.SetText("I really need that gun");
                cullDown = 5.0f;
                Invoke("ClearText", 2.0f);
            }
        }

        if (collision.gameObject.name == "Stealth Portal") {
            SceneManager.LoadScene("Clock Level");
        }
    }

    private void ClearText() {
        textController.ClearText();
    }
}
