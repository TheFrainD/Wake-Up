using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public bool isActive = false;
    public float vertSpeed = 10f;
    public float horSpeed = 8f;
    
    Rigidbody2D rb;
    float horizontalInput;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        if (isActive) {
            rb.velocity = new Vector2(horizontalInput * horSpeed, vertSpeed);
            GetComponent<Animator>().SetBool("isFlying", true);
        } else {
            rb.velocity = Vector2.zero;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Pizda") {
            FindObjectOfType<LevelController>().GameOver();
        }
    }
}
