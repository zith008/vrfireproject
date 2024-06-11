using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial7UIButton : MonoBehaviour
{
    [SerializeField]
    GameObject UIPanel;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Hand")) {
            if (gameObject.name == "LeftButton") {
                UIPanel.GetComponent<Tutorial7TextPanel>().onClickLeft();
            }

            if (gameObject.name == "RightButton") {
                UIPanel.GetComponent<Tutorial7TextPanel>().onClickRight();
            }
        }
    }
}
