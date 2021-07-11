using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantVelocity : MonoBehaviour
{
    public Vector3 direction;
    public float speed;

    private void FixedUpdate() {
        transform.Translate(direction * speed * Time.fixedDeltaTime);
    }
}
