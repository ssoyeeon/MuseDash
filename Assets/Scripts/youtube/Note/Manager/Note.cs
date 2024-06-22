using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float noteSpeed = 400;

    void Start()
    {
        
    }

    void Update()
    {
        transform.localPosition += Vector3.right * noteSpeed * Time.deltaTime;
        
    }
}
