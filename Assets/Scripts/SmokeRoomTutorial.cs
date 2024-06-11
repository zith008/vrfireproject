using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmokeRoomTutorial : MonoBehaviour
{
    public ParticleSystem smoke;
    public GameObject triggerArea;
    public GameObject hankerchief;
    public Tutorial7TextPanel tutorial;

    private bool isChanging = false;

    // Start is called before the first frame update
    void Start()
    {
        smoke.Stop();
    }

    public void StartSmoking() {
        smoke.Play();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject == triggerArea && hankerchief.GetComponent<HankerchiefScript>().isWet) {
            tutorial.gameObject.SetActive(true);
            tutorial.finishText();
            smoke.Stop();
        }
    }
}
