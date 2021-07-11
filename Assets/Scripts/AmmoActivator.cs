using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoActivator : MonoBehaviour
{
    public GameObject ammo;

    KlocoTrigger trigger;
    bool done = false;

    private void Awake() {
        trigger = GetComponent<KlocoTrigger>();
    }

    private void Update() {
        if (trigger.wasTriggered && !done) {
            done = true;
            ammo.SetActive(true);
        }
    }
}
