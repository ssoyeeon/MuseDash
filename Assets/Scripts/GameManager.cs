using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayerHp = 200;
    public int PlayerAttack = 3;
    public Monster monster;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "Player")
        {
            Debug.Log("∞À√‚«ﬂ¡ˆ∑’!");

            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("¥≠∑»¡ˆ∑’!");
                monster.MonsterHp -= PlayerAttack;
                Destroy(monster);
            }
        }
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
