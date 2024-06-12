using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Hand")) {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
