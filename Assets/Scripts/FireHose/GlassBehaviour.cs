using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassBehaviour : MonoBehaviour
{
    public void OnBreak()
    {
        gameObject.SetActive(false);
        Debug.Log("Glass has been broken");
    }

    public void OnHover()
    {
        Debug.Log("Glass is being hovered");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            gameObject.SetActive(false);
            Debug.Log("Glass has been broken");
        }
    }
}
