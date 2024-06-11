using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using UnityEngine;

public class ReelValveHandler : MonoBehaviour
{
    public bool isOn = false;
    [SerializeField] private DoorHandler doorHandler;
    [SerializeField] private OneGrabRotateTransformer transformer;
    [SerializeField] private HoseValveHandler hoseValveHandler;
    private bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        transformer.Constraints.MinAngle.Value = 0;
        transformer.Constraints.MaxAngle.Value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(transform.localRotation.y);
        if (doorHandler.isDoorOpen() && !isOpen)
        {
            transformer.Constraints.MaxAngle.Value = 180;
            isOpen = true;
        }
        
        if (transform.localRotation.y > 0.9f)
        {
            isOn = true;
            hoseValveHandler.OpenValve();
        }
        else
        {
            isOn = false;
            hoseValveHandler.CloseValve();
        }
    }
}
