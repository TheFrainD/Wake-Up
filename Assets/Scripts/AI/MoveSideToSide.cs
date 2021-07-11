using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSideToSide : MonoBehaviour
{
    public float speed;

    Rigidbody2D rbody;

    private void Awake() {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Move() {
        rbody.MovePosition(rbody.position + (Vector2)transform.up * speed * Time.fixedDeltaTime);
    }

    void Rotate() {
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + 180.0f);
    }

    private void FixedUpdate() {
        Move();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Car Trigger") {
            Rotate();
        }
    }
}
