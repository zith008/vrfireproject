using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PhoneCall : MonoBehaviour
{
    public bool onTouch;

    public Material metal;
    public Material white;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Hand")) {
            onTouch = true;
            this.gameObject.GetComponent<MeshRenderer>().material = white;
            Material[] mats = this.gameObject.GetComponent<MeshRenderer>().materials;
            mats[0] = metal;
            mats[1] = white;
            this.gameObject.GetComponent<MeshRenderer>().materials = mats;
        }
    }
}
