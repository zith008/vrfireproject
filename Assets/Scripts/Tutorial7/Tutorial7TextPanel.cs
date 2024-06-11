using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial7TextPanel : MonoBehaviour
{
    private string[] text;

    private int curr;

    private GameObject textField;

    // Start is called before the first frame update
    void Start()
    {
        textField = gameObject.transform.Find("Text").gameObject;
        curr = 0;
        text = new string[4];
        text[0] = "Welcome again to FireDay: Emergency Response Training. In this tutorial, we will learn about the correct actions to take when trapped in a smoke-logged room. It is vital to know these steps as they can significantly reduce injury in such situations.";
        text[1] = "If you are in a smoke-logged room, remember not to panic as this can worsen the situation. Instead, follow these critical steps:";
        text[2] = "Cover your nose and mouth with a wet cloth and avoid inhaling through the mouth. This can help filter out some of the smoke and provide cleaner air for you to breathe.";
        text[3] = "Get down, keep close to the ground and crawl towards the point of escape under the smoke. Smoke rises, so the air near the floor will be clearer.";

        /*
        text[5] = "Now, let's put this knowledge to the test. You are in your bedroom when suddenly smoke starts entering the room.";
        text[6] = "Great job! By following these steps, you've effectively increased your chances of survival in a smoke-logged room. Remember these steps as they could be life-saving in an actual emergency.";
        */

        //Default text
        textField.GetComponent<TextMeshProUGUI>().SetText(text[0]);
    }

    // Update is called once per frame
    void Update()
    {
        //textField.GetComponent<TextMeshProUGUI>().SetText("A");
    }

    public void onClickLeft() 
    {
        if (curr > 0)
        {
            textField.GetComponent<TextMeshProUGUI>().SetText(text[curr-1]);
            curr = curr - 1;
        }
    }

    public void onClickRight()
    {
        if (curr < text.Length - 1)
        {
            textField.GetComponent<TextMeshProUGUI>().SetText(text[curr+1]);
            curr = curr + 1;
        }
    }
}
