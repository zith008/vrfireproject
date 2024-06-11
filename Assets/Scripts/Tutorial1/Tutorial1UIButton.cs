using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial1UIButton : MonoBehaviour
{
    [SerializeField]
    GameObject UIPanel;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Hand")) {
            if (gameObject.name == "LeftButton") {
                UIPanel.GetComponent<Tutorial1TextPanel>().onClickLeft();
            }

            if (gameObject.name == "RightButton") {
                UIPanel.GetComponent<Tutorial1TextPanel>().onClickRight();
            }
        }
    }
}
