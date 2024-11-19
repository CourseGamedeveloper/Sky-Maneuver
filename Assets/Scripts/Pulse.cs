using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    [SerializeField]
    [Tooltip(" minimum scale for the sun(Circle) when do pulse")]
    float Min_Scale = 0.5f;
    
    [SerializeField]
    [Tooltip("max scale for the sun(Circle) when do pulse")]
    float max_Scale = 2f;

    [SerializeField]
    [Tooltip("speed for the pulse")]
    float puls_Speed = 1f;


    private Vector3 ScaleOfsun;

    // Start is called before the first frame update
    void Start()
    {
        //save the orginal scale sun
        ScaleOfsun = transform.localScale;
        
    }

    // Update is called once per frame
    void Update()
    {

       float scale=Mathf.Lerp(Min_Scale,max_Scale,Mathf.Sin(Time.time*puls_Speed));  
       transform.localScale = ScaleOfsun*scale;
        
    }
}
