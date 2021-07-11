using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed;

    Rigidbody2D rb;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start() {
        transform.Rotate(0.0f, 0.0f, 90.0f);
        rb.velocity = (Vector2)transform.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        // Do smth
        Destroy(gameObject);
    }
}
