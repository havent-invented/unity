using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    private float s = 5.0f;
    private float turnspeed = 25.0f;
    private float hIn;
    private float FIn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hIn = Input.GetAxis("Horizontal");
        FIn = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * s * FIn);
        transform.Rotate(Vector3.up * Time.deltaTime * s * hIn);
    }
}
