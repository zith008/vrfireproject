using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial7UIButton : MonoBehaviour
{
    [SerializeField]
    GameObject UIPanel;

    void OnMouseDown() {
        if (gameObject.name == "LeftButton")
        {
            UIPanel.GetComponent<Tutorial7TextPanel>().onClickLeft();
        }

        if (gameObject.name == "RightButton")
        {
            UIPanel.GetComponent<Tutorial7TextPanel>().onClickRight();
        }
    }
}
