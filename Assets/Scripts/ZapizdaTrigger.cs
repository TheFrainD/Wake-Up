using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZapizdaTrigger : MonoBehaviour
{
    public GameObject zapizdka;

    float coolDown = 0.0f;

    private void FixedUpdate() {
        if (coolDown >= 0.0f) {
            coolDown -= Time.fixedDeltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            if (coolDown <= 0.0f) {
                zapizdka.SetActive(true);
                Invoke("CloseZapizka", 8.0f);
                coolDown = 12.0f;
                FindObjectOfType<PlayerController>().canMove = false;
            }
        }
    }

    void CloseZapizka() {
        zapizdka.SetActive(false);
        FindObjectOfType<PlayerController>().canMove = true;
    }
}
