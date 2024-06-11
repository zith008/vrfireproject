using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject fireExtinguisherTutorial;
    public GameObject fireHoseTutorial;
    public GameObject trappedTutorial;
    public GameObject stopDropTutorial;
    public GameObject smokeRoomTutorial;
    public GameObject mainScenario;

    private bool isChanging;
    private float delay;

    private void Start() {
        delay = Time.time + 5f;
    }

    private void OnTriggerEnter(Collider other) {
        if (!isChanging && Time.time >= delay) {
            if (other.gameObject == fireExtinguisherTutorial) {
                print("Teleporting to Fire Extinguisher");
                SceneManager.LoadScene(1);
            } else if (other.gameObject == fireHoseTutorial) {
                print("Teleporting to Fire Hose");
                SceneManager.LoadScene(2);
            } else if (other.gameObject == trappedTutorial) {
                print("Teleporting to Trapped");
                SceneManager.LoadScene(3);
            } else if (other.gameObject == stopDropTutorial) {
                print("Teleporting to On Fire");
                SceneManager.LoadScene(4);
            } else if (other.gameObject == smokeRoomTutorial) {
                print("Teleporting to Smoke Room");
                SceneManager.LoadScene(5);
            } else if (other.gameObject == mainScenario) {
                print("Teleporting to Main Scenario");
            }

            isChanging = true;
        }
    }
}
