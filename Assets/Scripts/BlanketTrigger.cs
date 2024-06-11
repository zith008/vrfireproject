using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BlanketTrigger : MonoBehaviour
{
    public bool inPlace = false;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Blanket") {
            other.gameObject.transform.SetParent(transform, true);
            other.transform.localPosition = Vector3.zero;
            other.transform.localRotation = Quaternion.Euler(90f, 90f, 0f);
            other.transform.localScale = new Vector3(135f, 245f, 1000);
            other.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
            inPlace = true;
        }
    }
}
