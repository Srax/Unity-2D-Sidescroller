using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDoDamage : MonoBehaviour
{
    public GameObject Player;
    public float damageDone = 1f;

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            Damage(Player.transform);
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
