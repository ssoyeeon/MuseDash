using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageMove : MonoBehaviour
{
    public float MoveSpeed = 20.0f;

    void Start()
    {
        
    }

    void Update()
    {
        gameObject.transform.position += new Vector3(-1.0f, 0.0f, 0.0f) * Time.deltaTime * MoveSpeed;

        if(gameObject.transform.position.x < -14)
        {
            gameObject.transform.position += new Vector3(24.0f, 0.0f, 0.0f);
        }
    }
}
