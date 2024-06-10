using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    bool active = false;

    public float time = 60.0f; //60 seconds before the fire gets uncontrollable

    public bool timeEnd = false;

    public void Begin() {
        active = true;
    }

    void Update()
    {
        if (active) {
            time -= Time.deltaTime;
        }

        if (time <= 0.0f) {
            timeEnd = true;
        }
    }

    public void timerStop() {
        active = false;
    }
}
