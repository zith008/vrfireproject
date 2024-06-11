using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial3UIButton : MonoBehaviour
{
    [SerializeField]
    GameObject UIPanel;

    void OnMouseDown() {
        if (gameObject.name == "LeftButton")
        {
            UIPanel.GetComponent<Tutorial3TextPanel>().onClickLeft();
        }

        if (gameObject.name == "RightButton")
        {
            UIPanel.GetComponent<Tutorial3TextPanel>().onClickRight();
        }
    }
}
