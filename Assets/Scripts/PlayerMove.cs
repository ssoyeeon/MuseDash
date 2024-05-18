using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Force = 300f;
    public float FForce = -300f;
    public Rigidbody2D rig;

    private bool IsJump;
    private bool IsSit;

    void Start()
    {
        IsJump = false;
        IsSit = false;
    }

    void Update()
    {
        Jump();
        Sit();
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!IsJump)
            {
                IsJump = true;
                rig.velocity = Vector2.zero;
                rig.AddForce(new Vector2(0.0f, Force));
            }
        }
        else return;
    }

    void Sit()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (!IsSit)
            {
                IsSit = true;
                rig.velocity = Vector2.zero;
                rig.AddForce(new Vector2(0.0f, FForce));
            }
        }
        else return;
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Ãæµ¹");
            IsJump = false;
            IsSit = false;
        }
    }
}
