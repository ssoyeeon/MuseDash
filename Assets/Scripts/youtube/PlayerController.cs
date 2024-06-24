using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    TimingManager theTimingManager;
    public GameObject Note1;
    public GameObject Note2;

    void Start()
    {
        theTimingManager = FindObjectOfType<TimingManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Note1 != null)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                theTimingManager.CheckTiming();
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                theTimingManager.CheckTiming();
            }
        }

        if (Note2 != null)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                theTimingManager.CheckTiming();
            }
            else if (Input.GetKeyDown(KeyCode.K))
            {
                theTimingManager.CheckTiming();
            }
        }
    }
}
