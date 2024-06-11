using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePin : MonoBehaviour
{
    public FireExtinguisherHandle handle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Handle")
        {
            //TODO: Remove pin
            handle.hasPin = false;
            gameObject.SetActive(false);
        }
    }
}
