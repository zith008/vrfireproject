using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHose : MonoBehaviour
{
    public ParticleSystem nozzle;
    public Tutorial2TextPanel tutorial;

    // Start is called before the first frame update
    void Start()
    {
        nozzle.Stop();
    }

    private void OnParticleCollision(GameObject other) {
        if (other.CompareTag("Fire")) {
            other.GetComponent<ParticleSystem>().Stop();
            tutorial.gameObject.SetActive(true);
            tutorial.finishText();
        }
    }
}
