using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KokonScript : MonoBehaviour
{
    public GameObject spiders;
    int lives = 3;
    public KokonManager kokonManager;


    private void Update() {
        if (lives == 0) {
            kokonManager.KokonDestroyed();
            spiders.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Bullet") {
            lives--;
        }
    }
}
