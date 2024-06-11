using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopDropTutorial : MonoBehaviour
{
    public ParticleSystem fire;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        fire.Stop();
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    public void StartFire() {
        fire.Play();
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("MainCamera")) {
            fire.Stop();
            canvas.SetActive(true);
            canvas.GetComponent<Tutorial5TextPanel>().finishText();
        }
    }
}
