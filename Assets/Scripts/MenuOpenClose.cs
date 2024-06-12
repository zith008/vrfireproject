using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOpenClose : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;

    void Start() {
        menu.SetActive(false);
    }

    public void OpenMenu() {
        menu.SetActive(true);
    }

    public void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Hand")) {
            menu.SetActive(false);
        }
    }
}
