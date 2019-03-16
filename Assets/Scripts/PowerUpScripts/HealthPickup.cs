using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public GameObject GameMaster;
    public GameObject healthParticles;

    public float healthGiven = 1f;
    public float worth = 5;

    private bool isTrigger = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!isTrigger)
        {
            if (col.tag == "Player")
            {
                isTrigger = true;
                Heal(GameMaster.transform);

                GameObject effectIns = (GameObject)Instantiate(healthParticles, transform.position, transform.rotation); //Spawn a bullet shatter effect     
                Destroy(effectIns, 2f); //Destroy bullet shatter effect

                Destroy(gameObject);
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

    void Heal(Transform player)
    {
        GameControllerScript p = GameMaster.GetComponent<GameControllerScript>();

        if (p != null)
        {
            p.AddHealth(healthGiven);
            p.AddScore(worth);
        }
    }
}
