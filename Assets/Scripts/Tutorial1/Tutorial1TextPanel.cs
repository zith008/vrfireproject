using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial1TextPanel : MonoBehaviour
{
    private string[] text;

    private int curr;

    private GameObject textField;

    // Start is called before the first frame update
    void Start()
    {
        textField = gameObject.transform.Find("Text").gameObject;
        curr = 0;
        text = new string[6];
        text[0] = "Welcome to FireDay: Home Fire Safety Training. In this tutorial, we will learn how to use a fire extinguisher effectively. Remember, being prepared can save lives.";
        text[1] = "First, let's understand the basics of using a fire extinguisher with the P.A.S.S. method: Pull, Aim, Squeeze, Sweep.";
        text[2] = "Pull out the safety pin as instructed on the label.";
        text[3] = "Aim the nozzle at the base of the fire.";
        text[4] = "Squeeze the lever to release the extinguishing agent.";
        text[5] = "Sweep the nozzle from side to side to cover the area of the fire.";

        //separate panel
        /*
        text[6] = "Now, let's put what we've learned into practice. You are in a bedroom, and a fire starts in a paper-filled dustbin.";
        text[7] = "Great job! You have successfully extinguished the fire.";
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
