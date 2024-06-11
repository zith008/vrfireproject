using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial6UIButton : MonoBehaviour
{
    [SerializeField]
    GameObject UIPanel;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Hand")) {
            if (gameObject.name == "LeftButton") {
                UIPanel.GetComponent<Tutorial6TextPanel>().onClickLeft();
            }

            if (gameObject.name == "RightButton") {
                UIPanel.GetComponent<Tutorial6TextPanel>().onClickRight();
            }
        }
    }
}
