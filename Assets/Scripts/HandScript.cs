using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction.Input;
using Oculus.Interaction.HandGrab;

public class HandScript : MonoBehaviour
{
    public Hand hand;
    public HandGrabInteractor handGrabInteractor;
    public bool isGrabbing;
    public bool isPinching;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isGrabbing = handGrabInteractor.HasSelectedInteractable;
        isPinching = hand.GetIndexFingerIsPinching();
    }
}
