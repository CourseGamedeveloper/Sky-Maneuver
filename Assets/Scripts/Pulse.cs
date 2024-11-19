using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Minimum scale for the sun (Circle) when pulsing.")]
    private float Min_Scale = 0.5f;

    [SerializeField]
    [Tooltip("Maximum scale for the sun (Circle) when pulsing.")]
    private float Max_Scale = 2f;

    [SerializeField]
    [Tooltip("Speed of the pulse.")]
    private float Pulse_Speed = 1f;

    private Vector3 OriginalScale;

    // Start is called before the first frame update
    void Start()
    {
        // Save the original scale of the sun
        OriginalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the scale factor using Mathf.Lerp and Mathf.Sin
        float scale = Mathf.Lerp(Min_Scale, Max_Scale, Mathf.Sin(Time.time * Pulse_Speed));

        // Apply the calculated scale to the object
        transform.localScale = OriginalScale * scale;
    }
}
