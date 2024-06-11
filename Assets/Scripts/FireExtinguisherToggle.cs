using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisherToggle : MonoBehaviour
{
    public ParticleSystem nozzle;

    // Start is called before the first frame update
    void Start()
    {
        nozzle.Pause();
    }

    private void OnParticleCollision(GameObject other) {
        if (other.CompareTag("Fire")) {
            other.GetComponent<ParticleSystem>().Stop();
        }
    }
}
