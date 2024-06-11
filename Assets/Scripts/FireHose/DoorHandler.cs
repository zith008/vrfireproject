using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using UnityEngine;

public class DoorHandler : MonoBehaviour
{
    [SerializeField] private OneGrabRotateTransformer transformer;
    private bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        transformer.Constraints.MinAngle.Value = 0;
        transformer.Constraints.MaxAngle.Value = 0;
    }

    public void OpenDoor()
    {
        transformer.Constraints.MinAngle.Value = -180;
        isOpen = true;
    }

    public bool isDoorOpen()
    {
        return isOpen;
    }
}
