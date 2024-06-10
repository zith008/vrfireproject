using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLogic : MonoBehaviour
{
    bool active = false;

    public float time = 60.0f; //60 seconds before the fire gets uncontrollable

    public bool timeEnd = false;


    void Start()
    {
        active = true;
    }

    void Update()
    {
        if (GetComponent<Item>().isInteracted)
        {

            transform.localScale -= new Vector3(0.000001f, 0.000001f, 0.000001f);

            if (transform.localScale.x <= 0.001f)
            {
                Destroy(gameObject);
            }
        }

        if (active) 
        {
            time -= Time.deltaTime;
            transform.localScale += new Vector3(0.0000001f, 0.0000001f, 0.0000001f);
        }

        if (time <= 0.0f && active) 
        {
            timeEnd = true;
            active = false;
            Debug.Log("Game over");
        }
    }

    public void timerStop() 
    {
        active = false;
    }
}
