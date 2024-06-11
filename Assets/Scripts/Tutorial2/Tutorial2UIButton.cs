using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2UIButton : MonoBehaviour
{
    [SerializeField]
    GameObject UIPanel;

    void OnMouseDown() {
        if (gameObject.name == "LeftButton")
        {
            UIPanel.GetComponent<Tutorial2TextPanel>().onClickLeft();
        }

        if (gameObject.name == "RightButton")
        {
            UIPanel.GetComponent<Tutorial2TextPanel>().onClickRight();
        }
    }
}
