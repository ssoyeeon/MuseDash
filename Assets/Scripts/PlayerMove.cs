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
    private bool IsPlay;

    public int PlayerHp = 200;
    public int PlayerAttack = 3;

    public GameObject monster;
    public int MonsterHp = 1;

    void Start()
    {
        IsJump = false;
        IsSit = false;
        IsPlay = true;
    }

    void Update()
    {
        Jump();
        Sit();
        GameOver();
        Attack();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            PlayerHp -= 20;
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            IsJump = false;
            IsSit = false;
        }
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MonsterHp -= PlayerAttack;
        }

        if(MonsterHp <=0)
        {
            Destroy(monster);
        }
    }    

    void GameOver()
    {
        if (gameObject.CompareTag("Player"))
        {
            PlayerHp = 0;
            IsPlay = false;
        }
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
}
