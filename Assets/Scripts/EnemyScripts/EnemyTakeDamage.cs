using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{
    public GameObject Enemy;
    public float damageTaken = 1f;

    public bool isTrigger = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!isTrigger)
        {
            isTrigger = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (isTrigger)
        {
            if(col.tag == "Player")
            {
                Damage(Enemy.transform);
                isTrigger = false; //Allows for another object to be struck by this one
            }
        }
    }

    void Damage(Transform enemy)
    {
        EnemyHP e = enemy.GetComponent<EnemyHP>();

        if (e != null)
        {
            e.TakeDamage(damageTaken);
        }
    }
}
