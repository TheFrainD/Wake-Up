using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopdownShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    PlayerTopdownController playerController;

    private void Awake() {
        playerController = GetComponent<PlayerTopdownController>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.LeftControl) && playerController.canMove) {
            Shoot();
        }
    }

    void Shoot() {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
