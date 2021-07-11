using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    public Transform target;
    [SerializeField]
    public Vector3 offset;
    [SerializeField]
    public float damping;

    private Vector3 curerntVelocity = Vector3.zero;


    void FixedUpdate()
    {
        Vector3 moveBy = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, moveBy, ref curerntVelocity, damping);
    }
}
