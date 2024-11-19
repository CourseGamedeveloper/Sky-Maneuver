using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Speed of rotation in degrees per second.")]
    public float rotationSpeed = 100f;
    [Tooltip("Axis of rotation.")]
    public Vector3 rotationAxis = Vector3.up;

    void Update()
    {
        //this line to make the black Rotate
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
