using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{
    public GameObject Enemy;
    public float damageTaken = 1f;

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            Damage(Enemy.transform);
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
