using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisherHandle : MonoBehaviour
{
    public HandScript hand1 = null;
    public HandScript hand2 = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hand1 != null && hand1.isGrabbing)
        {
            // TODO: Water comes out
            Debug.Log("Water comes out");
        }
        if (hand2 != null && hand2.isGrabbing)
        {
            // TODO: Water comes out
            Debug.Log("Water comes out");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            HandScript handScript = other.gameObject.GetComponent<HandScript>();
            if (hand1 == null)
            {
                hand1 = handScript;
            }
            else
            {
                hand2 = handScript;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            HandScript handScript = other.gameObject.GetComponent<HandScript>();
            if (hand1 == handScript)
            {
                hand1 = null;
            }
            else if (hand2 == handScript)
            {
                hand2 = null;
            }
        }
    }
}
