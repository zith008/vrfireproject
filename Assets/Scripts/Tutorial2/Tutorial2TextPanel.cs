using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial2TextPanel : MonoBehaviour
{
    private string[] text;

    private string finish = "Well done! You have successfully extinguished the fire.";

    private int curr;

    private GameObject textField;

    public GameObject leftButton;

    public GameObject image;

    private float _nextTime;

    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.transform.Find("Image").gameObject;
        image.SetActive(false);

        textField = gameObject.transform.Find("Text").gameObject;
        curr = 0;
        text = new string[6];
        text[0] = "Welcome back to FireDay: Home Fire Safety Training. In this tutorial, we will learn how to use a hose reel to extinguish fires. Remember, quick action can save lives and property.";
        text[1] = "Let's go through the steps of using a hose reel effectively.";
        text[2] = "Turn on the hose reel valve in an anti-clockwise direction.";
        text[3] = "Pull out the hose and test to see if there is water. Run it to the fire.";
        text[4] = "Turn on the water at the nozzle and direct it at the base of the fire.";
        text[5] = "Now, let's apply what we've learned. You are in a bedroom, and a fire starts in a paper-filled dustbin.";

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
        if (Time.time >= _nextTime && curr > 0)
        {
            textField.GetComponent<TextMeshProUGUI>().SetText(text[curr-1]);
            curr = curr - 1;

            _nextTime = Time.time + 0.5f;
        }
    }

    public void onClickRight()
    {
        if (Time.time >= _nextTime) {
            print(curr);
            if (curr < text.Length - 1) {
                textField.GetComponent<TextMeshProUGUI>().SetText(text[curr + 1]);
                curr = curr + 1;
            } else if (curr == text.Length - 1) {
                textField.SetActive(false);
                image.SetActive(true);                
            }else if (curr == text.Length) {
                //BLANK
                
                textField.SetActive(true);
                image.SetActive(false);        
                this.gameObject.SetActive(false);
                curr = curr + 1;
            }

            _nextTime = Time.time + 0.5f;
        }
    }

    public void finishText() {
        textField.GetComponent<TextMeshProUGUI>().SetText(finish);
        leftButton.SetActive(false);
    }
}
