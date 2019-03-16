using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDoDamage : MonoBehaviour
{
    public GameObject Player;
    public GameObject EnemyHeadCollider;

    public float damageDone = 1f;
    public bool isTrigger = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!isTrigger)
        {
            EnemyHeadCollider.GetComponent<BoxCollider2D>().enabled = true;
            isTrigger = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (isTrigger)
        {
            Damage(Player.transform);
            EnemyHeadCollider.GetComponent<BoxCollider2D>().enabled = false;
            isTrigger = false; //Allows for another object to be struck by this one
        }
    }
    void Damage(Transform player)
    {
        GameControllerScript gcs = player.GetComponent<GameControllerScript>();

        if (gcs != null)
        {
            gcs.TakeDamage(damageDone);
        }
    }
}


