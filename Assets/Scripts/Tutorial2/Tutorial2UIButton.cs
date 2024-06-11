using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2UIButton : MonoBehaviour
{
    [SerializeField]
    GameObject UIPanel;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Hand")) {
            if (gameObject.name == "LeftButton") {
                UIPanel.GetComponent<Tutorial2TextPanel>().onClickLeft();
            }

            if (gameObject.name == "RightButton") {
                UIPanel.GetComponent<Tutorial2TextPanel>().onClickRight();
            }
        }
    }
}
