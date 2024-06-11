using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial5UIButton : MonoBehaviour
{
    [SerializeField]
    GameObject UIPanel;

    void OnMouseDown() {
        if (gameObject.name == "LeftButton")
        {
            UIPanel.GetComponent<Tutorial5TextPanel>().onClickLeft();
        }

        if (gameObject.name == "RightButton")
        {
            UIPanel.GetComponent<Tutorial5TextPanel>().onClickRight();
        }
    }
}
