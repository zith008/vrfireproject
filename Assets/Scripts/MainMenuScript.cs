using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public GameObject fireExtinguisherTutorial;
    public GameObject fireHoseTutorial;
    public GameObject trappedTutorial;
    public GameObject stopDropTutorial;
    public GameObject smokeRoomTutorial;
    public GameObject mainScenario;

    private bool isChanging;

    private void OnTriggerEnter(Collider other) {
        if (!isChanging) {
            if (other.gameObject == fireExtinguisherTutorial) {
                print("Teleporting to Fire Extinguisher");
            } else if (other.gameObject == fireHoseTutorial) {
                print("Teleporting to Fire Hose");
            } else if (other.gameObject == trappedTutorial) {
                print("Teleporting to Trapped");
            } else if (other.gameObject == stopDropTutorial) {
                print("Teleporting to On Fire");
            } else if (other.gameObject == smokeRoomTutorial) {
                print("Teleporting to Smoke Room");
            } else if (other.gameObject == mainScenario) {
                print("Teleporting to Main Scenario");
            }

            isChanging = true;
        }
    }
}
