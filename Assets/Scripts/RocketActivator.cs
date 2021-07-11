using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketActivator : MonoBehaviour
{
    public RocketController rocketController;
    public CameraFollow cameraFollow;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            rocketController.isActive = true;
            cameraFollow.target = rocketController.transform;
            cameraFollow.offset.y = 8f;
            Invoke("ResetDamping", 1.0f);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    void ResetDamping() {
        cameraFollow.damping = 0.0f;
    }
}
