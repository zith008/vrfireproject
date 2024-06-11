using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HankerchiefScript : MonoBehaviour
{
    public Mesh wetHanker;
    public Material darkYellow;

    public bool isWet = false;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Water")) {
            this.GetComponent<MeshFilter>().mesh = wetHanker;
            this.GetComponent<MeshRenderer>().material = darkYellow;
            isWet = true;
        }
    }
}
