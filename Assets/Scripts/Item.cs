using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    [SerializeField]
    public bool isFlammeable = false;

    [SerializeField]
    public bool isOnFire = false;

    public bool isInteracted = false;

    private bool fireExists;

    GameObject firePrefab;

    // Start is called before the first frame update
    void Start()
    {
        firePrefab = (GameObject) Resources.Load("Fire", typeof(GameObject));
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnFire)
        {
            var fire = GameObject.Instantiate(firePrefab);
            fire.transform.parent = transform;
            fire.transform.position = new Vector3(transform.position.x, transform.position.y + 0.35f, transform.position.z);

            fireExists = true;
            isOnFire = false;
        } 
    }

    void OnMouseDown()
    {
        Debug.Log("Item has been interacted with");
        isInteracted = true;

        if (fireExists)
        {
            var fire = gameObject.transform.Find("Fire(Clone)");
            fire.transform.localScale -= new Vector3(0.000001f, 0.000001f, 0.000001f);
            if (fire.localScale.x == 1)
            {
                Destroy(fire);
            }
        }

        StartCoroutine(ResetInteract());
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("Item has been interacted with");
        isInteracted = true;

        //check for fire
        if (fireExists)
        {
            var fire = gameObject.transform.Find("Fire(Clone)");
            fire.transform.localScale -= new Vector3(0.000001f, 0.000001f, 0.000001f);
            if (fire.localScale.x == 1)
            {
                Destroy(fire);
            }
        }

        StartCoroutine(ResetInteract());
    }

    IEnumerator ResetInteract()
    {
        yield return new WaitForSeconds(0.1f);
        isInteracted = false;
    }
}
