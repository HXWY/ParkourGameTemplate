using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float slowDownFactor = 0.5f;
    public float slowDownLength = 2f;
    public GameObject SlowMoPP;

    void doSlowMotion()
    {
        Time.timeScale = slowDownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            doSlowMotion();
            SlowMoPP.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            Time.timeScale = 1f;
            SlowMoPP.SetActive(false);
        }
    }
}
