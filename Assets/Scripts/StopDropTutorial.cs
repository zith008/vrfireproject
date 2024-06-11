using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopDropTutorial : MonoBehaviour
{
    public ParticleSystem fire;
    // Start is called before the first frame update
    void Start()
    {
        fire.Stop();
    }

    public void StartFire() {
        fire.Play();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("MainCamera")) {
            fire.Stop();
        }
    }
}
