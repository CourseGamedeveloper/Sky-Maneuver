using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Tooltip("Direction of oscillation, e.g., Vector3.right for horizontal.")]
    public Vector3 oscillationDirection = Vector3.right;

    [SerializeField]
    [Tooltip("The start location for the airplane.")]
    private Vector3 StartPosition;

    [SerializeField]
    [Tooltip("Maximum distance for the airplane to move right or left.")]
    private float Maxdistance = 1;

    [SerializeField]
    [Tooltip("Speed for the airplane to move right or left.")]
    private float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // Save the start position for the airplane
        transform.position = StartPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the airplane right and left within the limit distance
        float offset = Mathf.Sin(Time.time * speed) * Maxdistance;
        transform.position = StartPosition + oscillationDirection.normalized * offset;
    }
}
