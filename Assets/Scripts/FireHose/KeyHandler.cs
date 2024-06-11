using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHandler : MonoBehaviour
{
    [SerializeField] private DoorHandler doorHandler;
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Holder")
        {
            gameObject.SetActive(false);
            doorHandler.OpenDoor();
        }
    }
}
