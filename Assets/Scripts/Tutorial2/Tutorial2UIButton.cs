using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2UIButton : MonoBehaviour
{
    [SerializeField]
    GameObject UIPanel;


    public void LeftButtonOnClick() {
        UIPanel.GetComponent<Tutorial2TextPanel>().onClickLeft();
    }

    public void RightButtonOnClick() {
        UIPanel.GetComponent<Tutorial2TextPanel>().onClickRight();
    }
}
