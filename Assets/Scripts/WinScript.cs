using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject SceneManager;

    private bool isTrigger = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!isTrigger)
        {
            if (col.tag == "Player")
            {
                isTrigger = true;
                SceneManager.GetComponent<LoadScene>().WinScene();
            }
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (isTrigger)
        {
            if (col.tag == "Player")
            {
                isTrigger = false; //Allows for another object to be struck by this one
            }

        }
    }
}
