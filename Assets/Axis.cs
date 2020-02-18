using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");
    float hPos = h * hRange;
    float vPos = v * vRange;


    }
}
