using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrappedTutorial : MonoBehaviour
{
    public GameObject door;
    public GameObject window;
    public BlanketTrigger blanket;
    public PhoneCall phoneCall;
    public Tutorial6TextPanel tutorial6TextPanel;

    public bool closedDoor = false;
    public bool openedWindow = false;

    private void Update() {
        if (!closedDoor && door.transform.localEulerAngles.z <= 5) {
            closedDoor = true;
        }

        if (!openedWindow && window.transform.localEulerAngles.z > 280 && window.transform.localEulerAngles.z < 300) {
            openedWindow = true;
        }

        if (blanket.inPlace && phoneCall.onTouch && closedDoor && openedWindow) {
            tutorial6TextPanel.gameObject.SetActive(true);
            tutorial6TextPanel.finishText();
        }
    }
}
