using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTopdownCollisionController : MonoBehaviour
{
    PlayerTopdownController playerController;

    private void Awake() {
        playerController = GetComponent<PlayerTopdownController>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.name == "Gun") {
            playerController.isArmed = true;
            playerController.spriteRenderer.sprite = playerController.spriteArmed;

            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "Portal") {
            if (playerController.isArmed) {
                SceneManager.LoadScene("Stealth Carpet");
            }
        }
    }
}
