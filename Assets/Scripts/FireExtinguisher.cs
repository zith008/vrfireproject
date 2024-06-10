using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    private bool isPinned = true;

    [SerializeField]
    GameObject waterPrefab;

    [SerializeField]
    GameObject pinPrefab;

    [SerializeField]
    GameObject leverPrefab;

    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        isPinned = false; //testing
    }

    // Update is called once per frame
    void Update()
    {
        //rigidbody.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 1, Camera.main.transform.position.z);
    }

    //pickup fire extinguisher
    public void OnGrab()
    {

    }

    //remove pin
    public void OnPinch() 
    {
        isPinned = false;
    }

    public void OnUse()
    {
        if (!isPinned)
        {
            var water = GameObject.Instantiate(waterPrefab);
            water.transform.parent = transform;
        }
    }

    public void OnMouseDown()
    {
        var water = GameObject.Instantiate(waterPrefab);
        //water.transform.parent = transform;
        //water.transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);

        water.transform.position = transform.position + Camera.main.transform.forward * 2;
        Rigidbody rb = water.GetComponent<Rigidbody>();
        rb.velocity = Camera.main.transform.forward * 10;
    }
}
