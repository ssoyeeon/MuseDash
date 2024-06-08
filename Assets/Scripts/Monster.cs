using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int MonsterHp = 1;
    public int MonsterAttack = 20;
    public GameManager Manager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(tag == "PlayerMove")
        {
            Manager.PlayerHp -= MonsterAttack;
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
