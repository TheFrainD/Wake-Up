using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform target;
    [SerializeField]
    Vector3 offset;
    [SerializeField]
    float damping;

    private Vector3 curerntVelocity = Vector3.zero;


    void FixedUpdate()
    {
        Vector3 moveBy = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, moveBy, ref curerntVelocity, damping);
    }
}
