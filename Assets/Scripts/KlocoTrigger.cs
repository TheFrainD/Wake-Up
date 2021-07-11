using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlocoTrigger : MonoBehaviour
{
    public GameObject other;

    public bool wasTriggered = false;
    private bool isMoving = false;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player" && !wasTriggered) {
            wasTriggered = true;
            isMoving = true;
        }
    }

    private void Update() {
        if (isMoving) {
            if (transform.position.y < 10.0f) {
                transform.position += Vector3.up * 3f * Time.deltaTime;
                other.transform.position -= Vector3.up * 3f * Time.deltaTime;
            } else {
                isMoving = false;
            }
        }
    }
}
