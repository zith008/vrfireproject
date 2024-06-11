using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial1UIButton : MonoBehaviour
{
    [SerializeField]
    GameObject UIPanel;

    public void LeftButtonOnClick() {
        UIPanel.GetComponent<Tutorial1TextPanel>().onClickLeft();
    }

    public void RightButtonOnClick() {
        UIPanel.GetComponent<Tutorial1TextPanel>().onClickRight();
    }
}
