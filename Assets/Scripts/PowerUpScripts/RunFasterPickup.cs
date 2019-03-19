using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunFasterPickup : MonoBehaviour
{
    public GameObject player;
    public GameObject particles;

    public float plusSpeed = 50f;
    public float speedDuration = 10f;
    public float worth = 5;

    private bool isTrigger = false;

    private IEnumerator coroutine;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!isTrigger)
        {
            if (col.tag == "Player")
            {
                isTrigger = true;
                ChangeRunSpeed(player.transform);
                GameObject effectIns = (GameObject)Instantiate(particles, transform.position, transform.rotation); //Spawn a bullet shatter effect     
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


    void ChangeRunSpeed(Transform player)
    {
        PlayerMovementScript p = this.player.GetComponent<PlayerMovementScript>();

        if (p != null)
        {
            p.StartCoroutine(p.SpeedUp(speedDuration));
        }
    }
}
