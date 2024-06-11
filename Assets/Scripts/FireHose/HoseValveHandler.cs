using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoseValveHandler : MonoBehaviour
{
    private Rigidbody rb;
    private bool isOpen = false;
    private bool isOn = false;
    private bool isFree = false;
    [SerializeField] private GameObject valve;

    public ParticleSystem water;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (valve.transform.localRotation.z <-0.9 && isOpen && !isOn)
        {
            // TODO: start the water flow
            Debug.Log("Water Hose is flowing");
            isOn = true;
            water.Play();
        }
        else if (valve.transform.localRotation.z >= -0.9 && isOpen && isOn)
        {
            // TODO: stop the water flow
            Debug.Log("Water Hose is not flowing");
            isOn = false;
            water.Stop();
        }
        if (isOn && !isOpen)
        {
            // TODO: stop the water flow
            Debug.Log("Water Hose is not flowing");
            isOn = false;
            water.Stop();
        }
        if (isFree && rb.isKinematic)
        {
            // rb.isKinematic = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit from:" + other.gameObject.tag);
        if (other.gameObject.tag == "Holder" && !isFree)
        {
            Debug.Log("Valve is open");
            // rb.isKinematic = false;
            isFree = true;
        }
    }

    public void OpenValve()
    {
        isOpen = true;
    }

    public void CloseValve()
    {
        isOpen = false;
    }
}
