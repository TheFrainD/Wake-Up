using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPicker : MonoBehaviour
{
    public GameObject portal;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            Debug.Log("PIDAR");
            portal.SetActive(true);
            Destroy(gameObject);
        }
    }
}
