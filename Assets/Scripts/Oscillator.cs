using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Tooltip("Direction of oscillation, e.g., Vector3.right for horizontal.")]
    public Vector3 oscillationDirection = Vector3.right;
    [SerializeField]
    [Tooltip("the Start Location for Airplane")]
    private Vector3 StartPosition;
    [SerializeField]
    [Tooltip("Max distance for airplane to move right or left")]
    private float Maxdistance=1;
    [SerializeField]
    [Tooltip("speed for airplane to move right or left")]
    private float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //save the start position for black airplane
        transform.position = StartPosition;

        
    }

    // Update is called once per frame
    void Update()
    {
        //to move the red -airplane right and left with limit distance
        float offset = Mathf.Sin(Time.time * speed) * Maxdistance;
        transform.position = StartPosition + oscillationDirection.normalized * offset;


    }
}
